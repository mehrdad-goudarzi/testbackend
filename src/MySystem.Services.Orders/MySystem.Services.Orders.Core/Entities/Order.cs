using System;
using MySystem.Services.Orders.Core.Events;

namespace MySystem.Services.Orders.Core.Entities
{
    public class Order : AggregateRoot
    {
        public Guid ProductId { get; private set; }
        public long Count { get; private set; }
        public Guid CustomerId { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Order(AggregateId id, Guid productId, long count, Guid customerId, DateTime createdAt)
        {
            Id = id;
            ProductId = productId;
            Count = count;
            CustomerId = customerId;
            CreatedAt = createdAt;
        }

        public static Order Create(AggregateId id, Guid productId, long count, Guid customerId, DateTime createdAt)
        {
            var order = new Order(id, productId, count, customerId, createdAt);

            order.AddEvent(new OrderAdded(order.Id, order.CustomerId, order.ProductId, order.Count, order.CreatedAt));

            return order;
        }
    }
}