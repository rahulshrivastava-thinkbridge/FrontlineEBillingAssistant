using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class RuleEntity
    {
        public RuleEntity()
        {
            RuleFieldProgrammedRuleEntities = new HashSet<RuleField>();
            RuleFieldRuleEntities = new HashSet<RuleField>();
            UserDefinedActions = new HashSet<UserDefinedAction>();
            UserDefinedConditions = new HashSet<UserDefinedCondition>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RuleField> RuleFieldProgrammedRuleEntities { get; set; }
        public virtual ICollection<RuleField> RuleFieldRuleEntities { get; set; }
        public virtual ICollection<UserDefinedAction> UserDefinedActions { get; set; }
        public virtual ICollection<UserDefinedCondition> UserDefinedConditions { get; set; }
    }
}
