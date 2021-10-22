using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZchartfordNavigatorsRule
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? LawFirmId { get; set; }
        public int? RuleId { get; set; }
        public bool? IsEnabled { get; set; }
        public int? DeactivatedFrom { get; set; }
        public int? ProductLineId { get; set; }
        public bool RejectedAsError { get; set; }
    }
}
