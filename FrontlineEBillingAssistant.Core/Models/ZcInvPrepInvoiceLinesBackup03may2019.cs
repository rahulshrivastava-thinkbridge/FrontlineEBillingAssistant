using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcInvPrepInvoiceLinesBackup03may2019
    {
        public int Id { get; set; }
        public int InvPrepInvoiceId { get; set; }
        public decimal TotalInvoiceValue { get; set; }
        public decimal Rate { get; set; }
        public decimal Fees { get; set; }
        public string Description { get; set; }
        public bool IsEditable { get; set; }
    }
}
