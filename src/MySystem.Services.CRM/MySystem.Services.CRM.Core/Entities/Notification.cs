using System;
using MySystem.Services.CRM.Core.Events;
using MySystem.Services.CRM.Core.Exceptions;

namespace MySystem.Services.CRM.Core.Entities
{
    public class Notification : AggregateRoot
    {
        public Notification(AggregateId id, Guid customerId, string message)
        {
            CustomerId = customerId;
            Message = message;
        }

        public Guid CustomerId { get; private set; }
        public string Message { get; private set; }

        public static Notification Create(AggregateId id, Guid customerId, string message)
        {
            var notif = new Notification(id, customerId, message);

            notif.AddEvent(new NotificationCreated(customerId, message));

            return notif;
        }
    }
}