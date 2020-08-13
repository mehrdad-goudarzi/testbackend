using System;
using System.Collections.Generic;
using Convey.Logging.CQRS;
using MySystem.Services.CRM.Application.Events;

namespace MySystem.Services.CRM.Infrastructure.Logging
{
    internal sealed class MessageToLogTemplateMapper : IMessageToLogTemplateMapper
    {
        private static IReadOnlyDictionary<Type, HandlerLogTemplate> MessageTemplates 
            => new Dictionary<Type, HandlerLogTemplate>
            {
                {
                    typeof(NotificationAdded),     
                    new HandlerLogTemplate
                    {
                        After = "New Notification for customer with id: {CustomerId} has been added."
                    }
                }
            };
        
        public HandlerLogTemplate Map<TMessage>(TMessage message) where TMessage : class
        {
            var key = message.GetType();
            return MessageTemplates.TryGetValue(key, out var template) ? template : null;
        }
    }
}