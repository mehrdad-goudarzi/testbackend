using System;
using System.Linq;
using System.Threading.Tasks;
using Convey.CQRS.Commands;
using MySystem.Services.Orders.Application.Services;
using MySystem.Services.Orders.Core.Entities;
using MySystem.Services.Orders.Core.Exceptions;
using MySystem.Services.Orders.Core.Repositories;

namespace MySystem.Services.Orders.Application.Commands.Handlers
{
    public class CreateOrderHandler : ICommandHandler<CreateOrder>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMessageBroker _messageBroker;
        private readonly IEventMapper _eventMapper;

        public CreateOrderHandler(IOrderRepository orderRepository, ICustomerRepository customerRepository,
                                  IProductRepository productRepository, IMessageBroker messageBroker,
                                  IEventMapper eventMapper)
        {
            _orderRepository = orderRepository;
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _messageBroker = messageBroker;
            _eventMapper = eventMapper;
        }

        public async Task HandleAsync(CreateOrder command)
        {
            if (!(await _customerRepository.ExistsAsync(command.CustomerId)))
            {
                throw new CustomerNotFoundException(command.CustomerId);
            }
            
            if (!(await _productRepository.ExistsAsync(command.ProductId)))
            {
                throw new ProductNotFoundException(command.ProductId);
            }

            var order = Order.Create(command.OrderId, command.ProductId, command.Count, command.CustomerId,
                                     DateTime.UtcNow);
            await _orderRepository.AddAsync(order);
            var events = _eventMapper.MapAll(order.Events);
            await _messageBroker.PublishAsync(events.ToArray());
        }
    }
}