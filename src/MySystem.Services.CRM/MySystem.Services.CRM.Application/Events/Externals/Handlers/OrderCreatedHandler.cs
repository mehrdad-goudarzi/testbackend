using System;
using System.Linq;
using System.Threading.Tasks;
using Convey.CQRS.Events;
using MySystem.Services.CRM.Application.Services;
using MySystem.Services.CRM.Core.Entities;
using MySystem.Services.CRM.Core.Repositories;

namespace MySystem.Services.CRM.Application.Events.Externals.Handlers
{
    public class OrderCreatedHandler : IEventHandler<OrderCreated>
    {
        private readonly INotificationRepository notificationRepository;
        private readonly IMessageBroker messageBroker;
        private readonly IEventMapper eventMapper;

        public OrderCreatedHandler(INotificationRepository notificationRepository, IMessageBroker messageBroker,
                                   IEventMapper eventMapper)
        {
            this.notificationRepository = notificationRepository;
            this.messageBroker = messageBroker;
            this.eventMapper = eventMapper;
        }
        public async Task HandleAsync(OrderCreated @event)
        {
            string message = $"سفارش شما در تاریخ {@event.CreatedAt.ToString()} با موفقیت ثبت شد.";
            var notif = Notification.Create(Guid.NewGuid(), @event.CustomerId, message);
            await notificationRepository.InsertAsync(notif);
            var events = eventMapper.MapAll(notif.Events);
            await messageBroker.PublishAsync(events.ToArray());
        }
    }
}