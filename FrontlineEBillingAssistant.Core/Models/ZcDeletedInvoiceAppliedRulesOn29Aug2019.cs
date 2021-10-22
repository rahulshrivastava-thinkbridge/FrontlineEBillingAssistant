using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcDeletedInvoiceAppliedRulesOn29Aug2019
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int? LineItemId { get; set; }
        public int RuleId { get; set; }
        public string RuleCode { get; set; }
    }
}
