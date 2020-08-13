using System.Collections.Generic;
using Convey.CQRS.Events;
using MySystem.Services.CRM.Core;

namespace MySystem.Services.CRM.Application.Services
{
    public interface IEventMapper
    {
        IEvent Map(IDomainEvent @event);
        IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events);
    }
}