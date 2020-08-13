using System;
using System.Threading.Tasks;
using MySystem.Services.CRM.Core.Entities;

namespace MySystem.Services.CRM.Core.Repositories
{
    public interface INotificationRepository
    {
        Task InsertAsync(Notification notif);
    }
}