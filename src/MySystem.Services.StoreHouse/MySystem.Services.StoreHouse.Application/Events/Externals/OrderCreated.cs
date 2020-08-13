using System;
using Convey.CQRS.Events;
using Convey.MessageBrokers;

namespace MySystem.Services.StoreHouse.Application.Events.Externals
{
    [Message("orders")]
    public class OrderCreated : IEvent
    {
        public Guid Id { get; }
        public Guid CustomerId { get; }
        public Guid ProductId { get; }
        public long Count { get; }
        public DateTime CreatedAt { get; }

        public OrderCreated(Guid id, Guid customerId, Guid productId, long count, DateTime createdAt)
        {
            Id = id;
            CustomerId = customerId;
            ProductId = productId;
            Count = count;
            CreatedAt = createdAt;
        }
    }
}