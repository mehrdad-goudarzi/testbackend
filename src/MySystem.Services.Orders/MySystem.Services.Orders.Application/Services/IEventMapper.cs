using System.Collections.Generic;
using Convey.CQRS.Events;
using MySystem.Services.Orders.Core;

namespace MySystem.Services.Orders.Application.Services
{
    public interface IEventMapper
    {
        IEvent Map(IDomainEvent @event);
        IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events);
    }
}