using System.Collections.Generic;
using System.Linq;
using Convey.CQRS.Events;
using MySystem.Services.StoreHouse.Application.Events;
using MySystem.Services.StoreHouse.Application.Services;
using MySystem.Services.StoreHouse.Core;
using MySystem.Services.StoreHouse.Core.Entities;
using MySystem.Services.StoreHouse.Core.Events;

namespace MySystem.Services.StoreHouse.Infrastructure.Services
{
    public class EventMapper : IEventMapper
    {
        public IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events)
            => events.Select(Map);

        public IEvent Map(IDomainEvent @event)
        {
            switch (@event)
            {
                case InventoryUpdated e:
                    return new InventoryDecreased(e.ProductId, e.Inventory);
            }

            return null;
        }
    }
}