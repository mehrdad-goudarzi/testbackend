using System;

namespace MySystem.Services.CRM.Core.Events
{
    public class NotificationCreated : IDomainEvent
    {
        public Guid CustomerId { get; }
        public string Message { get; }

        public NotificationCreated(Guid customerId, string message)
        {
            CustomerId = customerId;
            Message = message;
        }
    }
}
