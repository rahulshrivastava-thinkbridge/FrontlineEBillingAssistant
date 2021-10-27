using System.Collections.Generic;
using System.Threading.Tasks;
using FrontlineEBillingAssistant.Repository.Interface;
using FrontlineEBillingAssistant.Service.Interface.Invoice;

namespace FrontlineEBillingAssistant.Service.Services.Invoice
{
    public class InvoiceLineItemService : IInvoiceLineItemService
    {
        private readonly IInvoiceLineItemRepository _invoiceLineItemRepo;
        private readonly IInvoiceLineItemGridRepository _invoiceLineItemGridRepository;

        public InvoiceLineItemService(IInvoiceLineItemRepository invoiceLineItemRepo)
        {
            _invoiceLineItemRepo = invoiceLineItemRepo;
        }

        public async Task<IEnumerable<Core.Models.InvoiceLineItem>> GetAllInvoiceLineItemsById(int Id)
        {
            return await _invoiceLineItemRepo.GetListById(Id);
        }

        public async Task<IEnumerable<Core.Models.InvoiceLineItem>> GetAllInvoiceLineItems()
        {
            return await _invoiceLineItemRepo.GetAll();
        }

        public async Task<IEnumerable<Core.Models.InvoiceLineItemsListingGridModel>> GetInvoiceLineItemsById(int Id)
        {
            return await _invoiceLineItemGridRepository.GetInvoiceLineItemsListing(Id);
        }
    }
}
