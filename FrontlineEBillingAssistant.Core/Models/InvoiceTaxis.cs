using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceTaxis
    {
        public int Id { get; set; }
        public int InvoiceFileId { get; set; }
        public string TaxId { get; set; }
        public string TaxVendorId { get; set; }
        public string TaxType { get; set; }
        public decimal TaxRatePercent { get; set; }
        public string TaxJurisdictionCountryCode { get; set; }
        public string TaxJurisdictionLocality { get; set; }
        public bool TaxOnTax { get; set; }
        public string TaxOnTaxId { get; set; }
        public int IncreaseOrDecrease { get; set; }
        public int FileItemNumber { get; set; }

        public virtual InvoiceFile InvoiceFile { get; set; }
    }
}
