using System.Collections.Generic;
using System.Threading.Tasks;
using FrontlineEBillingAssistant.Core.Models;

namespace FrontlineEBillingAssistant.Service.Interface.Invoice
{
    public interface IInvoiceLineItemService
    {
        Task<IEnumerable<InvoiceLineItem>> GetAllInvoiceLineItemsById(int Id);
        Task<IEnumerable<InvoiceLineItem>> GetAllInvoiceLineItems();
        Task<IEnumerable<InvoiceLineItemsListingGridModel>> GetInvoiceLineItemsById(int Id);
        int UpdateInvoiceLineItems(InvoiceLineItemsListingGridModel model);
    }
}
