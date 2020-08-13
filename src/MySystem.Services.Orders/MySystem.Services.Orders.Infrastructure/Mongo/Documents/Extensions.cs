using MySystem.Services.Orders.Application.DTO;
using MySystem.Services.Orders.Core.Entities;

namespace MySystem.Services.Orders.Infrastructure.Mongo.Documents
{
    public static class Extensions
    {
        public static Order AsEntity(this OrderDocument document)
            => new Order(document.Id, document.ProductId, document.Count, document.CustomerId, document.CreatedAt);

        public static OrderDocument AsDocument(this Order entity)
            => new OrderDocument
            {
                Id = entity.Id,
                CustomerId = entity.CustomerId,
                CreatedAt = entity.CreatedAt,
                Count = entity.Count,
                ProductId = entity.ProductId
            };

        public static OrderDto AsDto(this OrderDocument document)
            => new OrderDto
            {
                Id = document.Id,
                CustomerId = document.CustomerId,
                CreatedAt = document.CreatedAt,
                Count = document.Count,
                ProductId = document.ProductId
            };

        public static Customer AsEntity(this CustomerDocument document)
            => new Customer(document.Id);

        public static CustomerDocument AsDocument(this Customer entity)
            => new CustomerDocument
            {
                Id = entity.Id
            };

        public static Product AsEntity(this ProductDocument document)
            => new Product(document.Id);

        public static ProductDocument AsDocument(this Product entity)
            => new ProductDocument
            {
                Id = entity.Id
            };
    }
}