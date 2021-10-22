using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceTaxMatterDiscountCredit
    {
        public int Id { get; set; }
        public int InvoiceLineItemId { get; set; }
        public string TaxId { get; set; }
        public int FileItemNumber { get; set; }

        public virtual InvoiceLineItem InvoiceLineItem { get; set; }
    }
}
