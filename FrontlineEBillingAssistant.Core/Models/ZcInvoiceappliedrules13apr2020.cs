using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcInvoiceappliedrules13apr2020
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int? LineItemId { get; set; }
        public int RuleId { get; set; }
        public string RuleCode { get; set; }
    }
}
