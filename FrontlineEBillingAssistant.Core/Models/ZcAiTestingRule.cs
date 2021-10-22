using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcAiTestingRule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RuleCategoryId { get; set; }
    }
}
