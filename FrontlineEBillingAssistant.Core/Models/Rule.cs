using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class Rule
    {
        public Rule()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
            Invoices = new HashSet<Invoice>();
            MatterExceptions = new HashSet<MatterException>();
            UserDefinedActions = new HashSet<UserDefinedAction>();
            UserDefinedConditions = new HashSet<UserDefinedCondition>();
        }

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
        public int? RuleSetId { get; set; }
        public string ActionClassName { get; set; }
        public string ConditionClassName { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int CreatedById { get; set; }
        public int ModifiedById { get; set; }
        public int? PriorityNumber { get; set; }
        public bool ProcessNoMoreRules { get; set; }
        public bool? IsValidation { get; set; }
        public bool? IsExport { get; set; }
        public bool? IsManual { get; set; }
        public bool? IsPrebill { get; set; }
        public int? ValidationActionTypeId { get; set; }
        public int? ExportActionTypeId { get; set; }
        public int? ManualActionTypeId { get; set; }
        public int? PrebillActionTypeId { get; set; }
        public int? NewRuleId { get; set; }
        public string ManualAdjustmentNote { get; set; }
        public string ExportAdjustmentNote { get; set; }
        public string PrebillAdjustmentNote { get; set; }
        public bool? IsMerged { get; set; }
        public int? MergedTo { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual RuleArea RuleArea { get; set; }
        public virtual RuleCategory RuleCategory { get; set; }
        public virtual RuleSet RuleSet { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<MatterException> MatterExceptions { get; set; }
        public virtual ICollection<UserDefinedAction> UserDefinedActions { get; set; }
        public virtual ICollection<UserDefinedCondition> UserDefinedConditions { get; set; }
    }
}
