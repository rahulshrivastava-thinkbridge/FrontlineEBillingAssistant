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
    public class InvoiceRepository: Repository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(EBillingContext eBillingContext) : base(eBillingContext) { }

        public async Task<IEnumerable<Invoice>> GetAllInvoices()
        {
            return await _ebillingContext.Invoices.Take(1000).ToListAsync();
        }

        public async Task<IEnumerable<InvoiceReviewToolVM>> GetInvoiceDetailsById(int Id)
        {
            return await _ebillingContext.InvoiceDetails.FromSqlRaw<InvoiceReviewToolVM>("GetInvoiceDetailsById {0}", Id).ToListAsync();
        }
    }
}
