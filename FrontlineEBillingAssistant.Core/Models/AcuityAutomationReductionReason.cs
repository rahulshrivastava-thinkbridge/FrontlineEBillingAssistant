using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class AcuityAutomationReductionReason
    {
        public int Id { get; set; }
        public string ReductionKey { get; set; }
        public string ReductionReason { get; set; }
        public string AutomationId { get; set; }
        public int? CatogoryPriority { get; set; }
    }
}
