using FrontlineEBillingAssistant.Repository.Interface;
using FrontlineEBillingAssistant.Service.Interface.Invoice;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Service.Services.Invoice
{
    public class InvoiceListingGridService : IInvoiceListingGridService
    {
        private readonly IInvoiceListingGridRepository _invoiceListingGridRepository;

        public InvoiceListingGridService(IInvoiceListingGridRepository invoiceListingGridRepository)
        {
            _invoiceListingGridRepository = invoiceListingGridRepository;
        }

        public async Task<IEnumerable<Core.Models.InvoiceListingGridModel>> GetInvoiceListingGridResults()
        {
            return await _invoiceListingGridRepository.GetInvoiceListingGridResults();
        }

        public async Task<IEnumerable<Core.Models.InvoiceListingGridModel>> GetFilteredInvoiceListingGridResults(string filterType, string filterValue)
        {
            return await _invoiceListingGridRepository.GetFilteredInvoiceListingGridResults(filterType, filterValue);
        }

        public async Task<IEnumerable<Core.Models.InvoiceListingGridModel>> GetInvoiceListingGridResults(int pageNumber, int pageSize, string filterText)
        {
            return await _invoiceListingGridRepository.GetInvoiceListingGridResults(pageNumber, pageSize, filterText);
        }
    }
}
