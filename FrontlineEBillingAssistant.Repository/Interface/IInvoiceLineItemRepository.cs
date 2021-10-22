using System.Collections.Generic;
using System.Threading.Tasks;
using FrontlineEBillingAssistant.Core.Models;
using FrontlineEBillingAssistant.Repository.Interface.Base;

namespace FrontlineEBillingAssistant.Repository.Interface
{
    public interface IInvoiceLineItemRepository : IRepository<InvoiceLineItem>
    {
        public Task<IEnumerable<InvoiceLineItem>> GetListById(int Id);
    }
}
