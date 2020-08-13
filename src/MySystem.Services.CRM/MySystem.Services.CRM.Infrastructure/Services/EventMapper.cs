using System.Collections.Generic;
using System.Linq;
using Convey.CQRS.Events;
using MySystem.Services.CRM.Application.Events;
using MySystem.Services.CRM.Application.Services;
using MySystem.Services.CRM.Core;
using MySystem.Services.CRM.Core.Events;

namespace MySystem.Services.CRM.Infrastructure.Services
{
    public class EventMapper : IEventMapper
    {
        public IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events)
            => events.Select(Map);

        public IEvent Map(IDomainEvent @event)
        {
            switch (@event)
            {
                case NotificationCreated e:
                    return new NotificationAdded(e.CustomerId, e.Message);
            }

            return null;
        }
    }
}