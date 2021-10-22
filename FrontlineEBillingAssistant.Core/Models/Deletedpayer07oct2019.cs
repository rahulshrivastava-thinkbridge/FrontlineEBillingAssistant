using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class Deletedpayer07oct2019
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int LawFirmId { get; set; }
        public string TaxId { get; set; }
        public int Status { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedTime { get; set; }
        public decimal InvoicePrepRate { get; set; }
        public string SupportedInvoiceFormat { get; set; }
        public string MatterMatchingField { get; set; }
        public string SupportedOutputInvoiceFormat { get; set; }
        public decimal? InvoicePrepExpRate { get; set; }
        public string Ebiller { get; set; }
        public string EbillerUrl { get; set; }
        public string EbillerUserName { get; set; }
        public string EbillerPassword { get; set; }
        public string EbillerEmail { get; set; }
        public string EbillerComments { get; set; }
        public string EbillerReference1 { get; set; }
        public string EbillerReference2 { get; set; }
        public string EbillerStatus { get; set; }
        public string EbillerStatusComments { get; set; }
        public DateTime? EbillerStatusCheckDate { get; set; }
        public DateTime? EbillerStatusChangeDate { get; set; }
        public int? EbillerAutomationStatus { get; set; }
        public int? LawFirmEbillerId { get; set; }
        public string SupportedPrebillInputFormat { get; set; }
        public bool? EnablePreBill { get; set; }
        public int? InvoiceWorkflowType { get; set; }
        public int? PrebillWorkflowType { get; set; }
        public string Icrverbiage { get; set; }
        public int? InvoicePreparationReportType { get; set; }
        public int? InvoiceCorrectionReportType { get; set; }
        public int? PrebillPreparationReportType { get; set; }
        public int? PrebillCorrectionReportType { get; set; }
        public bool? IsUpdateMatchingPrebillNo { get; set; }
    }
}
