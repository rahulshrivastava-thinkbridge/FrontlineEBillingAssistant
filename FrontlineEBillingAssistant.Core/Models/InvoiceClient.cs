using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceClient
    {
        public InvoiceClient()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public int InvoiceFirmId { get; set; }
        public int? ClientId { get; set; }
        public string ClientCode { get; set; }
        public string LawFirmCode { get; set; }
        public string Name { get; set; }
        public string TaxId { get; set; }
        public string AddressAddress1 { get; set; }
        public string AddressAddress2 { get; set; }
        public string AddressAddress3 { get; set; }
        public string AddressCity { get; set; }
        public string AddressStateProvince { get; set; }
        public string AddressZipPostalCode { get; set; }
        public string AddressCountry { get; set; }
        public string AddressPhone { get; set; }
        public string AddressFax { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactContactCode { get; set; }
        public string ContactPhone { get; set; }
        public string ContactFax { get; set; }
        public string ContactEmail { get; set; }
        public string ClientCodeModified { get; set; }

        public virtual Client Client { get; set; }
        public virtual InvoiceFirm InvoiceFirm { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
