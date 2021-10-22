using FrontlineEBillingAssistant.Core.Models;
using FrontlineEBillingAssistant.Repository.Interface.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Repository.Interface
{
    public interface IInvoiceListingGridRepository : IRepository<InvoiceListingGridModel>
    {
        public Task<IEnumerable<InvoiceListingGridModel>> GetInvoiceListingGridResults();
        public Task<IEnumerable<InvoiceListingGridModel>> GetFilteredInvoiceListingGridResults(string filterType, string filterValue);
        public Task<IEnumerable<InvoiceListingGridModel>> GetInvoiceListingGridResults(int pageNumber, int pageSize, string filterText);
    }
}
