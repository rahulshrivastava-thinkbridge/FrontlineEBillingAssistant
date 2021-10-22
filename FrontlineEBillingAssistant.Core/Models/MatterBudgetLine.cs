using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MatterBudgetLine
    {
        public int Id { get; set; }
        public int MatterBudgetId { get; set; }
        public string Part { get; set; }
        public decimal? BudgetedAmount { get; set; }
        public decimal? PreTrackingAmount { get; set; }

        public virtual MatterBudget MatterBudget { get; set; }
    }
}
