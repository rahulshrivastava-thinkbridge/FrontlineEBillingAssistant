using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvPrepInvoice
    {
        public InvPrepInvoice()
        {
            InvPrepInvoiceLines = new HashSet<InvPrepInvoiceLine>();
            InvoicePrepInvoiceInvoiceRelns = new HashSet<InvoicePrepInvoiceInvoiceReln>();
        }

        public int Id { get; set; }
        public string InvPrepInvoiceNumber { get; set; }
        public DateTime InvoiceMonth { get; set; }
        public decimal TotalInvoiceValue { get; set; }
        public decimal TotalFees { get; set; }
        public int LawFirmId { get; set; }
        public int CreatedById { get; set; }
        public DateTime BilledDate { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxAmount { get; set; }
        public bool? HasSeparateRateForFeesAndExpense { get; set; }
        public decimal? FeesOnFees { get; set; }
        public decimal? FeesOnExpense { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual ICollection<InvPrepInvoiceLine> InvPrepInvoiceLines { get; set; }
        public virtual ICollection<InvoicePrepInvoiceInvoiceReln> InvoicePrepInvoiceInvoiceRelns { get; set; }
    }
}
