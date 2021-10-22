using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class RuleArea
    {
        public RuleArea()
        {
            ProgrammedActions = new HashSet<ProgrammedAction>();
            ProgrammedConditions = new HashSet<ProgrammedCondition>();
            Rules = new HashSet<Rule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<ProgrammedAction> ProgrammedActions { get; set; }
        public virtual ICollection<ProgrammedCondition> ProgrammedConditions { get; set; }
        public virtual ICollection<Rule> Rules { get; set; }
    }
}
