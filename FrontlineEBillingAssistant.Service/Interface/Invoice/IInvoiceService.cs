using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Service.Interface.Invoice
{
    public interface IInvoiceService
    {
        Task<Core.Models.Invoice> GetInvoiceById(int Id);
        Task<IEnumerable<Core.Models.Invoice>> GetAllInvoices();
        Task<IEnumerable<Core.Models.InvoiceReviewToolVM>> GetInvoiceDetailsById(int Id);
    }
}
