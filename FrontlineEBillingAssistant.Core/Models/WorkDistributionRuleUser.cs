using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class WorkDistributionRuleUser
    {
        public int Id { get; set; }
        public int WorkDistributionRuleId { get; set; }
        public int PreparerId { get; set; }

        public virtual User Preparer { get; set; }
        public virtual WorkDistributionRule WorkDistributionRule { get; set; }
    }
}
