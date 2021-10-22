using FrontlineEBillingAssistant.Core.Data;
using FrontlineEBillingAssistant.Core.Models;
using FrontlineEBillingAssistant.Repository.Interface;
using FrontlineEBillingAssistant.Repository.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Repository.Repository
{
    public class InvoiceListingGridRepository : Repository<InvoiceListingGridModel>, IInvoiceListingGridRepository
    {
        public InvoiceListingGridRepository(EBillingContext eBillingContext) : base(eBillingContext) { }

        public async Task<IEnumerable<InvoiceListingGridModel>> GetInvoiceListingGridResults()
        {
            return await _ebillingContext.InvoiceListingGrid.FromSqlRaw("EXEC GetInvoicesListing").ToListAsync();
        }

        public async Task<IEnumerable<InvoiceListingGridModel>> GetFilteredInvoiceListingGridResults(string filterType, string filterValue)
        {
            return await _ebillingContext.InvoiceListingGrid.FromSqlRaw<InvoiceListingGridModel>("GetFilteredInvoicesListing {0}, {1}", filterType, filterValue).ToListAsync();
        }

        public async Task<IEnumerable<InvoiceListingGridModel>> GetInvoiceListingGridResults(int pageNumber, int pageSize, string filterText)
        {
            return await _ebillingContext.InvoiceListingGrid.FromSqlRaw<InvoiceListingGridModel>("GetPagedInvoicesListing {0}, {1}, {2}", pageNumber, pageSize, filterText).ToListAsync();
        }
    }
}
