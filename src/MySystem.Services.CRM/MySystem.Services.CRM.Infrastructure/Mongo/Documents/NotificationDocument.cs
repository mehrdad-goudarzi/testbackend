using System;
using Convey.Types;

namespace MySystem.Services.CRM.Infrastructure.Mongo.Documents
{
    public class NotificationDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string Message { get; set; }
    }
}