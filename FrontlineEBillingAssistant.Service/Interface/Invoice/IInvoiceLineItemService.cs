using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Service.Interface.Invoice
{
    public interface IInvoiceLineItemService
    {
        Task<IEnumerable<Core.Models.InvoiceLineItem>> GetAllInvoiceLineItemsById(int Id);
        Task<IEnumerable<Core.Models.InvoiceLineItem>> GetAllInvoiceLineItems();
    }
}
