using MySystem.Services.CRM.Application;

namespace MySystem.Services.CRM.Infrastructure
{
    public interface IAppContextFactory
    {
        IAppContext Create();
    }
}