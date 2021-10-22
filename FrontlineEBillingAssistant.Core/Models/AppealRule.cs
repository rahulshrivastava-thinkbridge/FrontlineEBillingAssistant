using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class AppealRule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ClientId { get; set; }
        public int? LawFirmId { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public int? InvoiceTotalCondition { get; set; }
        public int? ClientCondition { get; set; }
        public decimal? Change { get; set; }
        public int? ChangeCondition { get; set; }
        public short? AllocationPolicy { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int? RuleOrder { get; set; }
        public int Status { get; set; }
        public int? PreparerId { get; set; }
        public int? PreparerCondition { get; set; }
        public decimal? PaidByPayer { get; set; }
        public int? PaidByPayerCondition { get; set; }
        public decimal? PayerFeeReduction { get; set; }
        public int? PayerFeeReductionCondition { get; set; }
        public decimal? PayerExpenseReduction { get; set; }
        public int? PayerExpenseReductionCondition { get; set; }
        public int? FeePromptPayCondition { get; set; }
        public int? ExpensePromptPayCondition { get; set; }
        public decimal? ReductionByPayer { get; set; }
        public int? ReductionByPayerCondition { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual User ModifiedBy { get; set; }
    }
}
