using FrontlineEBillingAssistant.Service.Interface.Invoice;
using FrontlineEBillingAssistant.Service.Services.Invoice;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FrontlineEBillingAssistant.Service
{
    public static class DependencyInjection
    {
        public static void RegisterInfrastructureServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddTransient<IInvoiceService, InvoiceService>();
            service.AddTransient<IInvoiceLineItemService, InvoiceLineItemService>();
            service.AddTransient<IInvoiceListingGridService, InvoiceListingGridService>();
            service.AddTransient<IBillyRetrainingService, BillyRetrainingService>();
        }
    }
}
