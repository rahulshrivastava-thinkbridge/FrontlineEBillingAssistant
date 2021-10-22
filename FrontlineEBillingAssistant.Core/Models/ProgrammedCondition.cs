using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ProgrammedCondition
    {
        public int Id { get; set; }
        public int RuleAreaId { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }

        public virtual RuleArea RuleArea { get; set; }
    }
}
