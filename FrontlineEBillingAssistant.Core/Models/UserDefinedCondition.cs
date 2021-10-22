using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class UserDefinedCondition
    {
        public int Id { get; set; }
        public int RuleId { get; set; }
        public int JoinerId { get; set; }
        public int RuleEntityId { get; set; }
        public int RuleFieldId { get; set; }
        public int OperandId { get; set; }
        public string Value { get; set; }
        public int? GroupNumber { get; set; }
        public int? GroupOperandId { get; set; }

        public virtual Rule Rule { get; set; }
        public virtual RuleEntity RuleEntity { get; set; }
        public virtual RuleField RuleField { get; set; }
    }
}
