using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class VwInvoiceInvalidation
    {
        public int Id { get; set; }
        public int? LawFirmId { get; set; }
        public string LawFirmName { get; set; }
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public string Ebiller { get; set; }
        public string InvoiceCode { get; set; }
        public int InvoiceStatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime UploadedDate { get; set; }
        public DateTime? WfstatusChangeDate { get; set; }
        public string EbillerStatus { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public decimal? InvoiceTotalModified { get; set; }
        public decimal? DeductedFeesByPayer { get; set; }
        public decimal? DeductedExpenseByPayer { get; set; }
        public decimal? PaidTotalByPayer { get; set; }
        public decimal? FinalPaidAmount { get; set; }
        public decimal? AppealResponseAmount { get; set; }
        public decimal? AppealResponseFees { get; set; }
        public decimal? AppealResponseExpenses { get; set; }
        public decimal? FinalPaidFees { get; set; }
        public decimal? FinalPaidExpenses { get; set; }
        public decimal? PromptDiscFeesPercen { get; set; }
        public decimal? PromptDiscExpensePercen { get; set; }
        public decimal? FinalPaidAmountWithDisc { get; set; }
        public decimal? PaidExpenseWithDisc { get; set; }
        public decimal? PaidFeesWithDisc { get; set; }
        public decimal? PaidFeesWithCostShare { get; set; }
        public decimal? PaidExpenseWithCostShare { get; set; }
        public decimal? PaidTotalWithCostShare { get; set; }
        public decimal? FinalPaymentReceivedAmount { get; set; }
        public decimal? InitialPaymentReceivedAmount { get; set; }
        public decimal? WriteOffReceivedAmount { get; set; }
        public decimal? EbillerOriginalBilledAmount { get; set; }
        public decimal? EbillerOriginalBilledFees { get; set; }
        public decimal? EbillerOriginalBilledExpenses { get; set; }
        public decimal? EbillerGuidelineAdjustments { get; set; }
        public decimal? EbillerCostshareAdjustments { get; set; }
        public decimal? EbillerPromptPayDiscounts { get; set; }
        public decimal? EbillerOtherDiscounts { get; set; }
        public string EbillerOtherDiscountDescription { get; set; }
        public decimal? EbillerProcessingFees { get; set; }
        public decimal? EbillerToPayAmount { get; set; }
        public string InvoiceValidationEbiller { get; set; }
        public decimal? TotalAppealAllowed { get; set; }
        public decimal? EbillerPromptPayAmount { get; set; }
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
        public decimal? EbillerInvNetTotal { get; set; }
        public string EbillerInvStatus { get; set; }
        public decimal? EbillerProcessingFees1 { get; set; }
        public decimal? EbillerFeeCostSharePercent { get; set; }
        public decimal? EbillerExpenseCostSharePercent { get; set; }
        public decimal? EbillerTotalApprovedIncludingAppeal { get; set; }
        public int IsAllAmountFieldValid { get; set; }
    }
}
