using System;
using Convey.CQRS.Events;

namespace MySystem.Services.CRM.Application.Events
{
    public class NotificationAdded : IEvent
    {
        public Guid CustomerId { get; }
        public string Message { get; }

        public NotificationAdded(Guid customerId, string message)
        {
            CustomerId = customerId;
            Message = message;
        }
    }
}