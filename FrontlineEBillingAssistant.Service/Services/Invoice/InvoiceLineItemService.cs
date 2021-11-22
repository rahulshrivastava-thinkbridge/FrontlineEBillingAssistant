using System.Collections.Generic;
using System.Threading.Tasks;
using FrontlineEBillingAssistant.Repository.Interface;
using FrontlineEBillingAssistant.Service.Interface.Invoice;
using FrontlineEBillingAssistant.Core.Models;

namespace FrontlineEBillingAssistant.Service.Services.Invoice
{
    public class InvoiceLineItemService : IInvoiceLineItemService
    {
        private readonly IInvoiceLineItemRepository _invoiceLineItemRepo;
        private readonly IInvoiceLineItemGridRepository _invoiceLineItemGridRepository;

        public InvoiceLineItemService(IInvoiceLineItemRepository invoiceLineItemRepo, IInvoiceLineItemGridRepository invoiceLineItemGridRepository)
        {
            _invoiceLineItemRepo = invoiceLineItemRepo;
            _invoiceLineItemGridRepository = invoiceLineItemGridRepository;
        }

        public async Task<IEnumerable<InvoiceLineItem>> GetAllInvoiceLineItemsById(int Id)
        {
            return await _invoiceLineItemRepo.GetListById(Id);
        }

        public async Task<IEnumerable<InvoiceLineItem>> GetAllInvoiceLineItems()
        {
            return await _invoiceLineItemRepo.GetAll();
        }

        public async Task<IEnumerable<InvoiceLineItemsListingGridModel>> GetInvoiceLineItemsById(int Id)
        {
            return await _invoiceLineItemGridRepository.GetInvoiceLineItemsListing(Id);
        }

        public int UpdateInvoiceLineItems(InvoiceLineItemsListingGridModel model)
        {
            return _invoiceLineItemGridRepository.UpdateInvoiceLineItems(model);
        }
    }
}
