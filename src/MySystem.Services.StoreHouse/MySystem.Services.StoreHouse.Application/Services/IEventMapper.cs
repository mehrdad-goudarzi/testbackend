using System.Collections.Generic;
using Convey.CQRS.Events;
using MySystem.Services.StoreHouse.Core;

namespace MySystem.Services.StoreHouse.Application.Services
{
    public interface IEventMapper
    {
        IEvent Map(IDomainEvent @event);
        IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events);
    }
}