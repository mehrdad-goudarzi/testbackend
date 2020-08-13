using System;

namespace MySystem.Services.StoreHouse.Core.Exceptions
{
    public class InvalidDecreaseInventoryException : DomainException
    {
        public override string Code { get; } = "invalid_inventory";
        public Guid ProductId { get; }

        public InvalidDecreaseInventoryException(Guid productId) : base($"Decrease Inventory of product with id: {productId} is not valid.")
        {
            ProductId = productId;
        }
    }
}