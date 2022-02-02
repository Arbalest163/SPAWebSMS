using Microsoft.Extensions.DependencyInjection;
using SPAWebSMS.WebApi.Models;

namespace SPAWebSMS.WebApi.Services
{
    public static class ServiceRegistrator
    {
        public static IServiceCollection AddUserService(this IServiceCollection services) => services
            .AddTransient<ISenderService<MessageViewModel>, FakeMessageSenderService>()
            ;
    }
}
