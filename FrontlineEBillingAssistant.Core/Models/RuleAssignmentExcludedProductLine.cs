using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class RuleAssignmentExcludedProductLine
    {
        public int Id { get; set; }
        public int? RuleAssignmentId { get; set; }
        public int? ProductLineId { get; set; }

        public virtual MasterProductLine ProductLine { get; set; }
    }
}
