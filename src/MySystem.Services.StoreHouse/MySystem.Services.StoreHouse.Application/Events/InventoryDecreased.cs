using System;
using Convey.CQRS.Events;

namespace MySystem.Services.StoreHouse.Application.Events
{
    public class InventoryDecreased : IEvent
    {
        public Guid ProductId { get; }
        public long Count { get; }

        public InventoryDecreased(Guid productId, long count)
        {
            ProductId = productId;
            Count = count;
        }
    }
}