using System;

namespace MySystem.Services.StoreHouse.Core.Events
{
    public class InventoryUpdated : IDomainEvent
    {
        public Guid ProductId { get; }
        public long Inventory { get; }

        public InventoryUpdated(Guid productId, long inventory)
        {
            ProductId = productId;
            Inventory = inventory;
        }
    }
}
