using MySystem.Services.CRM.Core.Entities;

namespace MySystem.Services.CRM.Infrastructure.Mongo.Documents
{
    public static class Extensions
    {
        public static Notification AsEntity(this NotificationDocument document)
            => new Notification(document.Id, document.CustomerId, document.Message);

        public static NotificationDocument AsDocument(this Notification entity)
            => new NotificationDocument
            {
                Id = entity.Id,
                CustomerId = entity.CustomerId,
                Message = entity.Message
            };
    }
}