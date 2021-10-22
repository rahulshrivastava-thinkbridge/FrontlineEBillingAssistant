using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Service.Interface.Invoice
{
    public interface IInvoiceListingGridService
    {
        Task<IEnumerable<Core.Models.InvoiceListingGridModel>> GetInvoiceListingGridResults();
        Task<IEnumerable<Core.Models.InvoiceListingGridModel>> GetFilteredInvoiceListingGridResults(string filterType, string filterValue);
        Task<IEnumerable<Core.Models.InvoiceListingGridModel>> GetInvoiceListingGridResults(int pageNumber, int pageSize, string filterText);
    }
}
