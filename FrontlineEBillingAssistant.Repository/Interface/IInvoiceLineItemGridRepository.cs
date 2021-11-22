using FrontlineEBillingAssistant.Core.Models;
using FrontlineEBillingAssistant.Repository.Interface.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Repository.Interface
{
    public interface IInvoiceLineItemGridRepository : IRepository<InvoiceLineItemsListingGridModel>
    {
        public Task<IEnumerable<InvoiceLineItemsListingGridModel>> GetInvoiceLineItemsListing(int Id);
        public Task<int> UpdateInvoiceLineItems(InvoiceLineItemsListingGridModel model);
    }
}
