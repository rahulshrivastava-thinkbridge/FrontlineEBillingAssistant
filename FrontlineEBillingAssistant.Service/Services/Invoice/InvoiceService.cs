using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FrontlineEBillingAssistant.Repository.Interface;
using FrontlineEBillingAssistant.Service.Interface.Invoice;

namespace FrontlineEBillingAssistant.Service.Services.Invoice
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepo;

        public InvoiceService(IInvoiceRepository invoiceRepo)
        {
            _invoiceRepo = invoiceRepo;
        }

        public async Task<Core.Models.Invoice> GetInvoiceById(int Id)
        {
            return await _invoiceRepo.GetById(Id);
        }

        public async Task<IEnumerable<Core.Models.Invoice>> GetAllInvoices()
        {
            try
            {
                return await _invoiceRepo.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
