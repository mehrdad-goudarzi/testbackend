using System;

namespace MySystem.Services.Orders.Application.DTO
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public long Count { get; set; }
        public DateTime CreatedAt { get; set; }

        public OrderDto()
        {
        }

        public OrderDto(Guid id, Guid customerId, Guid productId, long count, DateTime createdAt)
        {
            Id = id;
            CustomerId = customerId;
            ProductId = productId;
            Count = count;
            CreatedAt = createdAt;
        }
    }
}