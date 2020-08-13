using System.Linq;
using System.Threading.Tasks;
using Convey.CQRS.Events;
using MySystem.Services.StoreHouse.Application.Services;
using MySystem.Services.StoreHouse.Core.Repositories;

namespace MySystem.Services.StoreHouse.Application.Events.Externals.Handlers
{
    public class OrderCreatedHandler : IEventHandler<OrderCreated>
    {
        private readonly IProductRepository productRepository;
        private readonly IMessageBroker messageBroker;
        private readonly IEventMapper eventMapper;

        public OrderCreatedHandler(IProductRepository productRepository, IMessageBroker messageBroker,
                                   IEventMapper eventMapper)
        {
            this.productRepository = productRepository;
            this.messageBroker = messageBroker;
            this.eventMapper = eventMapper;
        }
        public async Task HandleAsync(OrderCreated @event)
        {
            var product = await productRepository.GetAsync(@event.Id);

            product.DecreaseInventory(@event.Count);

            await productRepository.UpdateAsync(product);
            var events = eventMapper.MapAll(product.Events);
            await messageBroker.PublishAsync(events.ToArray());
        }
    }
}