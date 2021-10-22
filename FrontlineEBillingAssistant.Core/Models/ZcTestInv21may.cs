﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcTestInv21may
    {
        public int Id { get; set; }
        public int InvoiceClientId { get; set; }
        public string RulesetApplied { get; set; }
        public string Tag { get; set; }
        public int InvoiceStatusId { get; set; }
        public DateTime UploadedDate { get; set; }
        public int? AssignedToUserId { get; set; }
        public int InputFormatId { get; set; }
        public bool IsHeaderModified { get; set; }
        public bool IsModified { get; set; }
        public string InvoiceCode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceDueDate { get; set; }
        public string InvoiceCurrency { get; set; }
        public string InvoiceOtherCurrency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string TaxInvoiceClientName { get; set; }
        public string TaxInvoiceClientAddressAddress1 { get; set; }
        public string TaxInvoiceClientAddressAddress2 { get; set; }
        public string TaxInvoiceClientAddressAddress3 { get; set; }
        public string TaxInvoiceClientAddressCity { get; set; }
        public string TaxInvoiceClientAddressStateProvince { get; set; }
        public string TaxInvoiceClientAddressZipPostalCode { get; set; }
        public string TaxInvoiceClientAddressCountry { get; set; }
        public string TaxInvoiceClientAddressPhone { get; set; }
        public string TaxInvoiceClientAddressFax { get; set; }
        public string TaxInvoiceClientTaxId { get; set; }
        public string BillToClientName { get; set; }
        public string BillToClientAddressAddress1 { get; set; }
        public string BillToClientAddressAddress2 { get; set; }
        public string BillToClientAddressAddress3 { get; set; }
        public string BillToClientAddressCity { get; set; }
        public string BillToClientAddressStateProvince { get; set; }
        public string BillToClientAddressZipPostalCode { get; set; }
        public string BillToClientAddressCountry { get; set; }
        public string BillToClientAddressPhone { get; set; }
        public string BillToClientAddressFax { get; set; }
        public string BillToClientTaxId { get; set; }
        public string PayableByClientName { get; set; }
        public string PayableByClientAddressAddress1 { get; set; }
        public string PayableByClientAddressAddress2 { get; set; }
        public string PayableByClientAddressAddress3 { get; set; }
        public string PayableByClientAddressCity { get; set; }
        public string PayableByClientAddressStateProvince { get; set; }
        public string PayableByClientAddressZipPostalCode { get; set; }
        public string PayableByClientAddressCountry { get; set; }
        public string PayableByClientAddressPhone { get; set; }
        public string PayableByClientAddressFax { get; set; }
        public string PayableByClientTaxId { get; set; }
        public DateTime TaxPointDate { get; set; }
        public bool IsThisAtaxInvoice { get; set; }
        public bool IsThisAcreditNote { get; set; }
        public string ReferenceInvoice { get; set; }
        public string PaymentTerms { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalTaxOther { get; set; }
        public decimal TotalDue { get; set; }
        public decimal TotalDueOther { get; set; }
        public string ImageFileName { get; set; }
        public int FileItemNumber { get; set; }
        public decimal NetTotal { get; set; }
        public decimal TotalFee { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal TotalDiscCred { get; set; }
        public string DescriptionModified { get; set; }
        public decimal TotalTaxModified { get; set; }
        public decimal TotalTaxOtherModified { get; set; }
        public decimal TotalDueModified { get; set; }
        public decimal TotalDueOtherModified { get; set; }
        public decimal NetTotalModified { get; set; }
        public decimal TotalFeeModified { get; set; }
        public decimal TotalExpenseModified { get; set; }
        public decimal TotalDiscCredModified { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public decimal? InvoiceTotalModified { get; set; }
        public DateTime? PreparedDate { get; set; }
        public int? RuleId { get; set; }
        public string RuleCode { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? ExportedDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public decimal? DeductedFeesByPayer { get; set; }
        public decimal? DeductedExpenseByPayer { get; set; }
        public decimal? PaidTotalByPayer { get; set; }
        public bool? IsAppealed { get; set; }
        public DateTime? AppealedDate { get; set; }
        public decimal? AppealedAmount { get; set; }
        public string AppealDescription { get; set; }
        public DateTime? AppealResponseDate { get; set; }
        public decimal? FinalPaidAmount { get; set; }
        public string AppealResponseDescription { get; set; }
        public int? PreparedByUserId { get; set; }
        public decimal? AppealResponseAmount { get; set; }
        public decimal? AppealedFees { get; set; }
        public decimal? AppealedExpenses { get; set; }
        public decimal? AppealResponseFees { get; set; }
        public decimal? AppealResponseExpenses { get; set; }
        public decimal? FinalPaidFees { get; set; }
        public decimal? FinalPaidExpenses { get; set; }
        public decimal? PromptDiscFeesPercen { get; set; }
        public decimal? PromptDiscExpensePercen { get; set; }
        public decimal? FinalPaidAmountWithDisc { get; set; }
        public decimal? PaidExpenseWithDisc { get; set; }
        public decimal? PaidFeesWithDisc { get; set; }
        public int? AppealStatus { get; set; }
        public int? WorkFlowOwnerId { get; set; }
        public int? ExportedById { get; set; }
        public int? ApprovedById { get; set; }
        public DateTime? WfstatusChangeDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? PreparationStartTime { get; set; }
        public DateTime? PreparationEndTime { get; set; }
        public string RejectReason { get; set; }
        public string ApproverComment { get; set; }
        public bool? DoesApproverWishSecondReview { get; set; }
        public bool? IsSentBackByApprover { get; set; }
        public decimal? FinalPaymentReceivedAmount { get; set; }
        public decimal? InitialPaymentReceivedAmount { get; set; }
        public DateTime? PaymentRecievedDate { get; set; }
        public DateTime? AppealCreditReceivedDate { get; set; }
        public decimal? AppealCreditReceivedAmount { get; set; }
        public DateTime? WriteOffReceivedDate { get; set; }
        public decimal? WriteOffReceivedAmount { get; set; }
        public string FirstApproverComment { get; set; }
        public string SecondApproverComment { get; set; }
        public string ClientApproverComment { get; set; }
        public int? CurrentApprovalRuleId { get; set; }
        public string AppealStatusComments { get; set; }
        public bool? IsFinalApprovalInCurrentRule { get; set; }
        public string ThirdApproverComment { get; set; }
        public int? CurrentLevelInApprovalProcess { get; set; }
        public bool IsLineLevelPayerReductionDataProcessed { get; set; }
        public bool IsLineLevelPayerAppealDataProcessed { get; set; }
        public int? PreviousWorkFlowOwnerId { get; set; }
        public int? PreviousInvoiceStatusId { get; set; }
        public DateTime? SubmittedToPayerDate { get; set; }
        public DateTime? ClientApprovedDate { get; set; }
        public DateTime? SendForClientApprovalDate { get; set; }
        public decimal? PaidFeesWithCostShare { get; set; }
        public decimal? PaidExpenseWithCostShare { get; set; }
        public decimal? PaidTotalWithCostShare { get; set; }
        public string EbillerReference1 { get; set; }
        public string EbillerReference2 { get; set; }
        public string EbillerStatus { get; set; }
        public string EbillerStatusComments { get; set; }
        public DateTime? EbillerStatusCheckDate { get; set; }
        public DateTime? EbillerStatusChangeDate { get; set; }
        public decimal? EbillerOriginalBilledAmount { get; set; }
        public decimal? EbillerCostshareAdjustments { get; set; }
        public decimal? EbillerPromptPayDiscounts { get; set; }
        public decimal? EbillerProcessingFees { get; set; }
        public decimal? EbillerOtherDiscounts { get; set; }
        public string EbillerOtherDiscountDescription { get; set; }
        public decimal? EbillerToPayAmount { get; set; }
        public decimal? EbillerGuidelineAdjustments { get; set; }
        public decimal? EbillerOriginalBilledFees { get; set; }
        public decimal? EbillerOriginalBilledExpenses { get; set; }
        public int IgnoreFromEbillerAutomation { get; set; }
        public DateTime? AppealDeadlineDate { get; set; }
        public string OfflineApproverEmail { get; set; }
        public string BillType { get; set; }
        public int? WorkFlowId { get; set; }
        public int? WorkFlowStageId { get; set; }
        public string ProcessedByWhichRuleSystem { get; set; }
        public int? PreparationReportType { get; set; }
        public int? CorrectionReportType { get; set; }
        public int? PreviousClientApprovalLevel { get; set; }
    }
}