using System;

namespace MySystem.Services.Orders.Core.Events
{
    public class OrderAdded : IDomainEvent
    {
        public Guid Id { get; }
        public Guid CustomerId { get; }
        public Guid ProductId { get; }
        public long Count { get; }
        public DateTime CreatedAt { get; }

        public OrderAdded(Guid id, Guid customerId, Guid productId, long count, DateTime createdAt)
        {
            Id = id;
            CustomerId = customerId;
            ProductId = productId;
            Count = count;
            CreatedAt = createdAt;
        }
    }
}
