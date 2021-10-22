using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceValidation
    {
        public int IpsInvoiceId { get; set; }
        public string IpsInvoiceCode { get; set; }
        public decimal? IpsInvoiceTotal { get; set; }
        public decimal? IpsInvoiceTotalModified { get; set; }
        public decimal? IpsDeductedFeesByPayer { get; set; }
        public decimal? IpsDeductedExpenseByPayer { get; set; }
        public decimal? IpsPaidTotalByPayer { get; set; }
        public decimal? IpsFinalPaidAmount { get; set; }
        public decimal? IpsAppealResponseAmount { get; set; }
        public decimal? IpsAppealResponseFees { get; set; }
        public decimal? IpsAppealResponseExpenses { get; set; }
        public decimal? IpsFinalPaidFees { get; set; }
        public decimal? IpsFinalPaidExpenses { get; set; }
        public decimal? IpsPromptDiscFeesPercen { get; set; }
        public decimal? IpsPromptDiscExpensePercen { get; set; }
        public decimal? IpsFinalPaidAmountWithDisc { get; set; }
        public decimal? IpsPaidExpenseWithDisc { get; set; }
        public decimal? IpsPaidFeesWithDisc { get; set; }
        public decimal? IpsPaidFeesWithCostShare { get; set; }
        public decimal? IpsPaidExpenseWithCostShare { get; set; }
        public decimal? IpsPaidTotalWithCostShare { get; set; }
        public string IpsInvStatus { get; set; }
        public string Ebiller { get; set; }
        public string EbillerIsAppeal { get; set; }
        public string EbillerIsCostShareApplied { get; set; }
        public string EbillerIsPromptPayApplied { get; set; }
        public string EbillerIsPromptPayFeesOnly { get; set; }
        public decimal? EbillerPromptPayAmount { get; set; }
        public decimal? EbillerPromptPayPercent { get; set; }
        public decimal? EbillerPromptPayPendPercent { get; set; }
        public decimal? EbillerInvNetTotal { get; set; }
        public string EbillerInvStatus { get; set; }
        public decimal? EbillerFeeOrigAmount { get; set; }
        public decimal? EbillerFeeAdjAmount { get; set; }
        public decimal? EbillerFeeCurrentAmount { get; set; }
        public decimal? EbillerFeeCostShareAdjAmount { get; set; }
        public decimal? EbillerFeeToPayAmount { get; set; }
        public decimal? EbillerExpenseOrigAmount { get; set; }
        public decimal? EbillerExpenseAdjAmount { get; set; }
        public decimal? EbillerExpenseCurrentAmount { get; set; }
        public decimal? EbillerExpenseCostShareAdjAmount { get; set; }
        public decimal? EbillerExpenseToPayAmount { get; set; }
        public decimal? EbillerTotalOrigAmount { get; set; }
        public decimal? EbillerTotalAdjAmount { get; set; }
        public decimal? EbillerTotalCurrentAmount { get; set; }
        public decimal? EbillerTotalCostShareAdjAmount { get; set; }
        public decimal? EbillerTotalToPayAmount { get; set; }
        public decimal? EbillerAppealApplied1 { get; set; }
        public decimal? EbillerAppealAllowed1 { get; set; }
        public decimal? EbillerAppealApplied2 { get; set; }
        public decimal? EbillerAppealAllowed2 { get; set; }
        public decimal? EbillerAppealApplied3 { get; set; }
        public decimal? EbillerAppealAllowed3 { get; set; }
        public decimal? EbillerAppealCostShareAdjustment1 { get; set; }
        public decimal? EbillerAppealPromptPayAdjustment1 { get; set; }
        public decimal? EbillerAppealProcessingFeesAdjustment1 { get; set; }
        public decimal? EbillerAppealToPay1 { get; set; }
        public decimal? EbillerAppealCostShareAdjustment2 { get; set; }
        public decimal? EbillerAppealPromptPayAdjustment2 { get; set; }
        public decimal? EbillerAppealProcessingFeesAdjustment2 { get; set; }
        public decimal? EbillerAppealToPay2 { get; set; }
        public decimal? EbillerAppealCostShareAdjustment3 { get; set; }
        public decimal? EbillerAppealPromptPayAdjustment3 { get; set; }
        public decimal? EbillerAppealProcessingFeesAdjustment3 { get; set; }
        public decimal? EbillerAppealToPay3 { get; set; }
        public decimal? EbillerProcessingFees { get; set; }
        public decimal? EbillerAppealAdjustment1 { get; set; }
        public decimal? EbillerAppealAdjustment2 { get; set; }
        public decimal? EbillerAppealAdjustment3 { get; set; }
        public decimal? EbillerFeeCostSharePercent { get; set; }
        public decimal? EbillerExpenseCostSharePercent { get; set; }
        public int? IsEbillerInformationUpdated { get; set; }
        public decimal? EbillerTotalApprovedIncludingAppeal { get; set; }
        public int IsAppealResponseValid { get; set; }
        public int IsPromptPayValid { get; set; }
        public int IsProcessingFeesValid { get; set; }
        public int IsInitialApprovalValid { get; set; }
        public int IsCostShareValid { get; set; }
        public int IsFinalPaidValid { get; set; }
        public int IsAllAmountFieldValid { get; set; }
        public int? IgnoreFromEbillingAutomation { get; set; }
    }
}
