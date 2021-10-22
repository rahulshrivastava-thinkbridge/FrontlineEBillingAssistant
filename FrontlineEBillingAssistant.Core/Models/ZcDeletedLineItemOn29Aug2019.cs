using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcDeletedLineItemOn29Aug2019
    {
        public int Id { get; set; }
        public int InvoiceMatterId { get; set; }
        public int? TimekeeperId { get; set; }
        public string RuleCode { get; set; }
        public string RuleNote { get; set; }
        public string Tag { get; set; }
        public int LineItemStatusId { get; set; }
        public bool IsModified { get; set; }
        public bool HasCommunication { get; set; }
        public DateTime ChargeDate { get; set; }
        public string LineItemTimekeeperId { get; set; }
        public string TimeKeeperName { get; set; }
        public string TimekeeperLastName { get; set; }
        public string TimekeeperFirstName { get; set; }
        public int TimekeeperLevel { get; set; }
        public string WorkLocationCountryCode { get; set; }
        public string WorkLocationLocality { get; set; }
        public string ChargeDesciption { get; set; }
        public string TaskCode { get; set; }
        public decimal Units { get; set; }
        public decimal? Rate { get; set; }
        public decimal BaseAmount { get; set; }
        public decimal ItemDiscountOrCreditAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int FileItemNumber { get; set; }
        public decimal TaxTotal { get; set; }
        public DateTime ChargeDateModified { get; set; }
        public string LineItemTimekeeperIdmodified { get; set; }
        public string TimeKeeperNameModified { get; set; }
        public string TimekeeperLastNameModified { get; set; }
        public string TimekeeperFirstNameModified { get; set; }
        public int TimekeeperLevelModified { get; set; }
        public string WorkLocationCountryCodeModified { get; set; }
        public string WorkLocationLocalityModified { get; set; }
        public string ChargeDesciptionModified { get; set; }
        public string TaskCodeModified { get; set; }
        public decimal UnitsModified { get; set; }
        public decimal? RateModified { get; set; }
        public decimal BaseAmountModified { get; set; }
        public decimal ItemDiscountOrCreditAmountModified { get; set; }
        public decimal? TotalAmountModified { get; set; }
        public int FileItemNumberModified { get; set; }
        public decimal TaxTotalModified { get; set; }
        public string TaskActivityCode { get; set; }
        public int? MatterDiscountCredit { get; set; }
        public string DiscountTypeNote { get; set; }
        public int? DiscountCreditType { get; set; }
        public int? DiscountCreditCategory { get; set; }
        public int? IncreaseOrDecrease { get; set; }
        public int? PrePostSplit { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public string TaskExpenseCode { get; set; }
        public string PayeeName { get; set; }
        public string Discriminator { get; set; }
        public int? ExtendHeaderExtendHeaderId { get; set; }
        public int? ExtendHeaderModifiedExtendHeaderId { get; set; }
        public int? InvoiceMatterId1 { get; set; }
        public int? InvoiceMatterId2 { get; set; }
        public int? InvoiceMatterId3 { get; set; }
        public int? RuleId { get; set; }
        public string PhaseCode { get; set; }
        public string TaskActivityCodeModified { get; set; }
        public string TaskExpenseCodeModified { get; set; }
        public string PreperationNote { get; set; }
        public string ChargeType { get; set; }
        public string ChargeTypeModified { get; set; }
        public int? RuleCategoryId { get; set; }
        public decimal? AgreedRate { get; set; }
        public DateTime? CommunicationModifiedDate { get; set; }
        public decimal? UnitsReducedByPayer { get; set; }
        public decimal? RateReducedByPayer { get; set; }
        public decimal? AmountReducedByPayer { get; set; }
        public string PayerReductionReason { get; set; }
        public int? NumberOfPayerReductions { get; set; }
        public decimal? UnAccountedAdjustments { get; set; }
        public string PayerReductionNarration { get; set; }
        public int? OrgLineNumber { get; set; }
    }
}
