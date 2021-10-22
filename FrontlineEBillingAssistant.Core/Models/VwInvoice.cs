using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class VwInvoice
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
        public DateTime? InvoiceDate { get; set; }
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
        public DateTime? Exporteddate { get; set; }
        public DateTime? PreparedDate { get; set; }
        public decimal Totalfee { get; set; }
        public decimal TotalExpenseModified { get; set; }
        public int? AppealStatus { get; set; }
        public decimal TotalDiscCred { get; set; }
        public string RejectReason { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal TotalFeeModified { get; set; }
        public string AppealStatusComments { get; set; }
        public decimal TotalTax { get; set; }
        public DateTime? SubmittedToPayerDate { get; set; }
    }
}
