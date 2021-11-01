using FrontlineEBillingAssistant.Core.Models;
using FrontlineEBillingAssistant.Repository.Interface.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Repository.Interface
{
    public interface IInvoiceRepository: IRepository<Invoice>
    {
        Task<IEnumerable<InvoiceReviewToolVM>> GetInvoiceDetailsById(int Id);
    }
}
