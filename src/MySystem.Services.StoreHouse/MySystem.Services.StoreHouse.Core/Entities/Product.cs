using System;
using MySystem.Services.StoreHouse.Core.Events;
using MySystem.Services.StoreHouse.Core.Exceptions;

namespace MySystem.Services.StoreHouse.Core.Entities
{
    public class Product : AggregateRoot
    {
        public long Inventory { get; private set; }

        public Product(Guid id, long inventory)
        {
            Id = id;
            Inventory = inventory;
        }

        public void DecreaseInventory(long count)
        {
            if (Inventory - count < 0)
            {
                throw new InvalidDecreaseInventoryException(Id.Value);
            }

            Inventory = Inventory - count;

            AddEvent(new InventoryUpdated(Id.Value, Inventory));
        }
    }
}