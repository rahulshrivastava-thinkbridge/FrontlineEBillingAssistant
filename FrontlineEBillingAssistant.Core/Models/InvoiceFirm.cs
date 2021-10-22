using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceFirm
    {
        public InvoiceFirm()
        {
            InvoiceClients = new HashSet<InvoiceClient>();
        }

        public int Id { get; set; }
        public int InvoiceFileId { get; set; }
        public int LawFirmId { get; set; }
        public string VendorUniqueId { get; set; }
        public string LawFirmId1 { get; set; }
        public string LawFirmName { get; set; }
        public string LawFirmAddressAddress1 { get; set; }
        public string LawFirmAddressAddress2 { get; set; }
        public string LawFirmAddressAddress3 { get; set; }
        public string LawFirmAddressCity { get; set; }
        public string LawFirmAddressStateProvince { get; set; }
        public string LawFirmAddressZipPostalCode { get; set; }
        public string LawFirmAddressCountry { get; set; }
        public string LawFirmAddressPhone { get; set; }
        public string LawFirmAddressFax { get; set; }
        public string LawFirmRemittanceAddressAddress1 { get; set; }
        public string LawFirmRemittanceAddressAddress2 { get; set; }
        public string LawFirmRemittanceAddressAddress3 { get; set; }
        public string LawFirmRemittanceAddressCity { get; set; }
        public string LawFirmRemittanceAddressStateProvince { get; set; }
        public string LawFirmRemittanceAddressZipPostalCode { get; set; }
        public string LawFirmRemittanceAddressCountry { get; set; }
        public string LawFirmRemittanceAddressPhone { get; set; }
        public string LawFirmRemittanceAddressFax { get; set; }
        public string LawFirmContactLastName { get; set; }
        public string LawFirmContactFirstName { get; set; }
        public string LawFirmContactContactCode { get; set; }
        public string LawFirmContactPhone { get; set; }
        public string LawFirmContactFax { get; set; }
        public string LawFirmContactEmail { get; set; }
        public string SourceApp { get; set; }
        public string AppVersion { get; set; }
        public string Url { get; set; }

        public virtual InvoiceFile InvoiceFile { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual ICollection<InvoiceClient> InvoiceClients { get; set; }
    }
}
