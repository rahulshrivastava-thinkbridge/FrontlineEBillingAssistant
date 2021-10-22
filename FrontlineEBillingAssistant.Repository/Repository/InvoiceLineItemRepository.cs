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
    public class InvoiceLineItemRepository : Repository<InvoiceLineItem>, IInvoiceLineItemRepository
    {
        public InvoiceLineItemRepository(EBillingContext eBillingContext) : base(eBillingContext) { }

        public async Task<IEnumerable<InvoiceLineItem>> GetListById(int Id)
        {
            return await _ebillingContext.InvoiceLineItems.Where(x => x.InvoiceMatterId == Id).ToListAsync();
        }
    }
}
