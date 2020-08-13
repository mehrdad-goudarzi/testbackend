using System.Collections.Generic;
using System.Linq;
using Convey.CQRS.Events;
using MySystem.Services.Orders.Application.Events;
using MySystem.Services.Orders.Application.Services;
using MySystem.Services.Orders.Core;
using MySystem.Services.Orders.Core.Entities;
using MySystem.Services.Orders.Core.Events;

namespace MySystem.Services.Orders.Infrastructure.Services
{
    public class EventMapper : IEventMapper
    {
        public IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events)
            => events.Select(Map);

        public IEvent Map(IDomainEvent @event)
        {
            switch (@event)
            {
                case OrderAdded e:
                    return new OrderCreated(e.Id, e.CustomerId, e.ProductId, e.Count, e.CreatedAt);
            }

            return null;
        }
    }
}