using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class RuleField
    {
        public RuleField()
        {
            UserDefinedActions = new HashSet<UserDefinedAction>();
            UserDefinedConditions = new HashSet<UserDefinedCondition>();
        }

        public int Id { get; set; }
        public bool IsConditionField { get; set; }
        public bool IsActionField { get; set; }
        public string Code { get; set; }
        public int RuleEntityId { get; set; }
        public string Name { get; set; }
        public int FieldTypeId { get; set; }
        public string Description { get; set; }
        public int? ProgrammedRuleEntityId { get; set; }

        public virtual RuleEntity ProgrammedRuleEntity { get; set; }
        public virtual RuleEntity RuleEntity { get; set; }
        public virtual ICollection<UserDefinedAction> UserDefinedActions { get; set; }
        public virtual ICollection<UserDefinedCondition> UserDefinedConditions { get; set; }
    }
}
