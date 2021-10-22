using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class VwDashboardTrackingAll
    {
        public int Id { get; set; }
        public string Invoicecode { get; set; }
        public int LawFirmId { get; set; }
        public string LawfirmName { get; set; }
        public string ClientName { get; set; }
        public int? ClientId { get; set; }
        public int Invoicestatusid { get; set; }
        public string Statusname { get; set; }
        public string Newstatusname { get; set; }
        public DateTime? Invoicedate { get; set; }
        public decimal InvoiceTotal { get; set; }
        public decimal InvoiceTotalModified { get; set; }
        public decimal FinalPaidAmount { get; set; }
        public decimal? PayerReduction { get; set; }
        public decimal Pending { get; set; }
        public decimal? Ipscorrection { get; set; }
        public decimal InvoicetotalmodifiedForIpscorrectionPercentage { get; set; }
        public int? WeekOfMonth { get; set; }
        public int? MonthNumber { get; set; }
        public int? YearNumber { get; set; }
        public string MonthName { get; set; }
        public DateTime Uploadeddate { get; set; }
        public int? DateValue { get; set; }
        public DateTime? StatusDate { get; set; }
        public string Ebillerstatus { get; set; }
        public DateTime? EbillerStatusDate { get; set; }
        public string Comments { get; set; }
        public string InvoiceType { get; set; }
        public decimal? NetReceivable { get; set; }
        public decimal? PendingWriteOff { get; set; }
        public decimal PaymentReceived { get; set; }
        public decimal WriteOff { get; set; }
        public decimal? GrossReceivable { get; set; }
        public decimal? NotSubmitted { get; set; }
        public string Lawfirmmatterid { get; set; }
        public string MatterName { get; set; }
        public string Clientmatterid { get; set; }
        public DateTime? Exporteddate { get; set; }
        public string AppealStatus { get; set; }
        public decimal OriginalFee { get; set; }
        public decimal OriginalExpenses { get; set; }
        public decimal OriginalTotal { get; set; }
        public decimal? IpscorrectionFee { get; set; }
        public decimal? IpscorrectionExpenses { get; set; }
        public decimal? IpscorrectionTotal { get; set; }
        public decimal SubmittedFee { get; set; }
        public decimal SubmittedExpenses { get; set; }
        public decimal SubmittedTotal { get; set; }
        public decimal PayerCorrectionFee { get; set; }
        public decimal PayerCorrectionExpenses { get; set; }
        public decimal PayerCorrectionTotal { get; set; }
        public decimal PayerApprovedAmount { get; set; }
        public decimal? CostShareAdjustment { get; set; }
        public decimal? PromptpayDiscounts { get; set; }
        public decimal OtherDiscounts { get; set; }
        public decimal ProcessingFees { get; set; }
        public decimal ToPayAmount { get; set; }
        public decimal? PayerAdjustmentFee { get; set; }
        public decimal? PayerAdjustmentExpense { get; set; }
        public decimal? PayerAdjustments { get; set; }
        public decimal? AppealedAmount { get; set; }
        public decimal? AppealResponseAmount { get; set; }
        public DateTime? AppealedDate { get; set; }
        public string NewAppealStatus { get; set; }
        public decimal? AppealRejectedAmount { get; set; }
        public decimal? PayerReductionBeforeAppeal { get; set; }
        public DateTime? AppealDeadlineDate { get; set; }
        public string ClaimNumber { get; set; }
        public int? WorkFlowId { get; set; }
        public DateTime? PreparedDate { get; set; }
    }
}
