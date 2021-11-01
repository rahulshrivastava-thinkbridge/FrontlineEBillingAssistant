using FrontlineEBillingAssistant.Core.Data;
using FrontlineEBillingAssistant.Core.Models;
using FrontlineEBillingAssistant.Repository.Interface;
using FrontlineEBillingAssistant.Repository.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Repository.Repository
{
    public class InvoiceLineItemGridRepository : Repository<InvoiceLineItemsListingGridModel>, IInvoiceLineItemGridRepository
    {
        public InvoiceLineItemGridRepository(EBillingContext eBillingContext) : base(eBillingContext) { }

        public async Task<IEnumerable<InvoiceLineItemsListingGridModel>> GetInvoiceLineItemsListing(int Id)
        {
            try
            {
                return await _ebillingContext.InvoiceLineItemsListingGrid.FromSqlRaw<InvoiceLineItemsListingGridModel>("GetInvoiceLineItemsById {0}", Id).ToListAsync();
            }
            catch (Exception ex)
            {
                return new List<InvoiceLineItemsListingGridModel>();
            }
        }
    }
}
