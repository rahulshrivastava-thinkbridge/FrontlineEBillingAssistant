using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcHannaBrophyCigaPrebillInvoiceMatching
    {
        public int InvoiceId { get; set; }
        public int PrebillId { get; set; }
        public string InvoiceNumber { get; set; }
        public string PrebillNumber { get; set; }
        public int? InvoiceMatterId { get; set; }
        public int? PrebillMatterId { get; set; }
        public string LawFirmMatterId { get; set; }
        public int InvStatusId { get; set; }
        public int PrebillStatusId { get; set; }
        public int? InvMonth { get; set; }
        public int? InvYear { get; set; }
    }
}
