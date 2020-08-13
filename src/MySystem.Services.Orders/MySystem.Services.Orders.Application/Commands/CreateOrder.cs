using System;
using Convey.CQRS.Commands;

namespace MySystem.Services.Orders.Application.Commands
{
    [Contract]
    public class CreateOrder : ICommand
    {
        public Guid OrderId { get; }
        public Guid CustomerId { get; }
        public Guid ProductId { get; }
        public long Count { get; }

        public CreateOrder(Guid orderId, Guid customerId, Guid productId, long count)
        {
            OrderId = orderId == Guid.Empty ? Guid.NewGuid() : orderId;
            CustomerId = customerId;
            ProductId = productId;
            Count = count;
        }
    }
}