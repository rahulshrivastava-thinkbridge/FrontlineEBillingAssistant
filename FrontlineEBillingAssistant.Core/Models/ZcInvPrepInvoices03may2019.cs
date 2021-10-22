using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcInvPrepInvoices03may2019
    {
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
    }
}
