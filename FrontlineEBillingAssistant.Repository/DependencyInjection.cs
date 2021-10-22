using FrontlineEBillingAssistant.Repository.Interface;
using FrontlineEBillingAssistant.Repository.Interface.Base;
using FrontlineEBillingAssistant.Repository.Repository;
using FrontlineEBillingAssistant.Repository.Repository.Base;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FrontlineEBillingAssistant.Repository
{
    public static class DependencyInjection
    {
        public static void RegisterRepositoryServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddScoped<IInvoiceRepository, InvoiceRepository>();
            service.AddScoped<IInvoiceLineItemRepository, InvoiceLineItemRepository>();
            service.AddScoped<IInvoiceListingGridRepository, InvoiceListingGridRepository>();
        }
    }
}
