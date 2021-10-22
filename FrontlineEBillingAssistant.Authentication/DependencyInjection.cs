using FrontlineEBillingAssistant.Authentication.Interfaces;
using FrontlineEBillingAssistant.Authentication.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FrontlineEBillingAssistant.Authentication
{
    public static class DependencyInjection
    {
        public static void RegisterAuthenticationServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddScoped<IUserService, UserService>();
        }
    }
}
