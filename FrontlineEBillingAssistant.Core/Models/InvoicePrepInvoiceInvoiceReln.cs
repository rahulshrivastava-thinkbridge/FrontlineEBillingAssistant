using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoicePrepInvoiceInvoiceReln
    {
        public int Id { get; set; }
        public int InvPrepInvoiceId { get; set; }
        public int InvoiceId { get; set; }
        public decimal Fees { get; set; }
        public decimal Rate { get; set; }
        public decimal? FeesOnFees { get; set; }
        public decimal? FeesOnExpense { get; set; }
        public decimal? ExpenseRate { get; set; }

        public virtual InvPrepInvoice InvPrepInvoice { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
