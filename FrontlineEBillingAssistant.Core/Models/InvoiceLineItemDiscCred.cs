using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceLineItemDiscCred
    {
        public int Id { get; set; }
        public int InvoiceLineItemId { get; set; }
        public int DiscCredCategory { get; set; }
        public int? DiscCredFee { get; set; }
        public int? DiscCredExpense { get; set; }
        public string DiscCredNote { get; set; }
        public int? DiscCredType { get; set; }
        public int? IncreaseDecrease { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? DiscCredAmount { get; set; }
        public int? InvoiceExpenseLineItemId { get; set; }
        public int? InvoiceFeeLineItemId { get; set; }

        public virtual InvoiceLineItem InvoiceExpenseLineItem { get; set; }
        public virtual InvoiceLineItem InvoiceFeeLineItem { get; set; }
        public virtual InvoiceLineItem InvoiceLineItem { get; set; }
    }
}
