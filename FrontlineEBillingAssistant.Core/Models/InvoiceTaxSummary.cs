using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceTaxSummary
    {
        public int Id { get; set; }
        public int InvoiceMatterId { get; set; }
        public string TaxId { get; set; }
        public decimal TaxableFees { get; set; }
        public decimal TaxOnFees { get; set; }
        public decimal TaxableExpense { get; set; }
        public decimal TaxOnExpense { get; set; }

        public virtual InvoiceMatter InvoiceMatter { get; set; }
    }
}
