using System;
using System.Threading.Tasks;
using Convey.Persistence.MongoDB;
using MySystem.Services.CRM.Core.Entities;
using MySystem.Services.CRM.Core.Repositories;
using MySystem.Services.CRM.Infrastructure.Mongo.Documents;

namespace MySystem.Services.CRM.Infrastructure.Mongo.Repositories
{
    public class NotificationMongoRepository : INotificationRepository
    {
        private readonly IMongoRepository<NotificationDocument, Guid> _repository;

        public NotificationMongoRepository(IMongoRepository<NotificationDocument, Guid> repository)
        {
            _repository = repository;
        }

        public Task InsertAsync(Notification notif)
        {
            return _repository.AddAsync(notif.AsDocument());
        }
    }
}