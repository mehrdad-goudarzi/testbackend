using System;

namespace MySystem.Services.Orders.Core.Exceptions
{
    public class ProductNotFoundException : DomainException
    {
        public override string Code { get; } = "product_not_found";
        public Guid ProductId { get; }

        public ProductNotFoundException(Guid productId) : base($"Product with id: {productId} was not found.")
        {
            ProductId = productId;
        }
    }
}