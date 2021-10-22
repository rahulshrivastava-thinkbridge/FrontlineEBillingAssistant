using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class RulesBackUp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AdjustmentNote { get; set; }
        public int RuleCategoryId { get; set; }
        public int RuleTypeId { get; set; }
        public int RuleAreaId { get; set; }
        public bool Status { get; set; }
        public int? ConditionType { get; set; }
        public int ActionTypeId { get; set; }
        public string Condition { get; set; }
        public string Action { get; set; }
        public bool ShouldPromptComment { get; set; }
        public int RuleSetId { get; set; }
        public string ActionClassName { get; set; }
        public string ConditionClassName { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int CreatedById { get; set; }
        public int ModifiedById { get; set; }
        public int? PriorityNumber { get; set; }
        public bool ProcessNoMoreRules { get; set; }
    }
}
