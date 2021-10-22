using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class LawFirm
    {
        public LawFirm()
        {
            AllocationRules = new HashSet<AllocationRule>();
            AppealRules = new HashSet<AppealRule>();
            ApprovalRules = new HashSet<ApprovalRule>();
            ClientDocuments = new HashSet<ClientDocument>();
            ClientInvPrepRates = new HashSet<ClientInvPrepRate>();
            CustomEmailTemplates = new HashSet<CustomEmailTemplate>();
            FirmClientHistoricalData = new HashSet<FirmClientHistoricalData>();
            FirmClientHistoricalDataLogs = new HashSet<FirmClientHistoricalDataLog>();
            InvPrepInvoices = new HashSet<InvPrepInvoice>();
            InvoiceFirms = new HashSet<InvoiceFirm>();
            InvoiceUploads = new HashSet<InvoiceUpload>();
            LawFirmContactPeople = new HashSet<LawFirmContactPerson>();
            LawFirmEbillers = new HashSet<LawFirmEbiller>();
            LawFirmMatterCustomFields = new HashSet<LawFirmMatterCustomField>();
            LawFirmNotes = new HashSet<LawFirmNote>();
            LawFirmOffices = new HashSet<LawFirmOffice>();
            LawfirmClients = new HashSet<LawfirmClient>();
            Matters = new HashSet<Matter>();
            Messages = new HashSet<Message>();
            PreBillUploads = new HashSet<PreBillUpload>();
            Users = new HashSet<User>();
            WorkDistributionRules = new HashSet<WorkDistributionRule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
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
        public string TaxId { get; set; }
        public string BillingCurrency { get; set; }
        public string RemitAddr1 { get; set; }
        public string RemitAddr2 { get; set; }
        public string RemitAddr3 { get; set; }
        public string RemitCity { get; set; }
        public string RemitPinCode { get; set; }
        public string RemitState { get; set; }
        public string RemitCountry { get; set; }
        public int Status { get; set; }
        public int CreatedById { get; set; }
        public int ModifiedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public decimal? InvoicePrepRate { get; set; }
        public string Code { get; set; }
        public string PaymentTerms { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? InvoicePrepExpRate { get; set; }
        public int? DefaultFeeQueryUserId { get; set; }
        public int? DefaultExpenseQueryUserId { get; set; }
        public int? DefaultFeeQueryContactPersonId { get; set; }
        public int? DefaultExpenseQueryContactPersonId { get; set; }
        public int? DefaultFeeQueryCopyUserId { get; set; }
        public int? DefaultExpenseQueryCopyUserId { get; set; }
        public int? DefaultFeeQueryCopyContactPersonId { get; set; }
        public int? DefaultExpenseQueryCopyContactPersonId { get; set; }
        public bool? AllowDrillDownInReduction { get; set; }
        public bool? EnablePrebill { get; set; }
        public int? InvoiceWorkflowType { get; set; }
        public int? PrebillWorkflowType { get; set; }
        public int? ReminderFrequency { get; set; }
        public bool? QueryReminderMailling { get; set; }
        public int? AutomationPriority { get; set; }
        public int? InvoicePreparationReportType { get; set; }
        public int? InvoiceCorrectionReportType { get; set; }
        public int? PrebillPreparationReportType { get; set; }
        public int? PrebillCorrectionReportType { get; set; }
        public int? LawFirmBillingSystemId { get; set; }
        public bool? IsLawfirmFileUpload { get; set; }
        public bool? EnableDuplicateMatter { get; set; }
        public bool? EnableInvoiceTotalCheck { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual LawFirmContactPerson DefaultExpenseQueryCopyContactPerson { get; set; }
        public virtual User DefaultExpenseQueryCopyUser { get; set; }
        public virtual User DefaultExpenseQueryUser { get; set; }
        public virtual LawFirmContactPerson DefaultFeeQueryCopyContactPerson { get; set; }
        public virtual User DefaultFeeQueryCopyUser { get; set; }
        public virtual User DefaultFeeQueryUser { get; set; }
        public virtual MasterLawFirmTimeAndBillingSystem LawFirmBillingSystem { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual ICollection<AllocationRule> AllocationRules { get; set; }
        public virtual ICollection<AppealRule> AppealRules { get; set; }
        public virtual ICollection<ApprovalRule> ApprovalRules { get; set; }
        public virtual ICollection<ClientDocument> ClientDocuments { get; set; }
        public virtual ICollection<ClientInvPrepRate> ClientInvPrepRates { get; set; }
        public virtual ICollection<CustomEmailTemplate> CustomEmailTemplates { get; set; }
        public virtual ICollection<FirmClientHistoricalData> FirmClientHistoricalData { get; set; }
        public virtual ICollection<FirmClientHistoricalDataLog> FirmClientHistoricalDataLogs { get; set; }
        public virtual ICollection<InvPrepInvoice> InvPrepInvoices { get; set; }
        public virtual ICollection<InvoiceFirm> InvoiceFirms { get; set; }
        public virtual ICollection<InvoiceUpload> InvoiceUploads { get; set; }
        public virtual ICollection<LawFirmContactPerson> LawFirmContactPeople { get; set; }
        public virtual ICollection<LawFirmEbiller> LawFirmEbillers { get; set; }
        public virtual ICollection<LawFirmMatterCustomField> LawFirmMatterCustomFields { get; set; }
        public virtual ICollection<LawFirmNote> LawFirmNotes { get; set; }
        public virtual ICollection<LawFirmOffice> LawFirmOffices { get; set; }
        public virtual ICollection<LawfirmClient> LawfirmClients { get; set; }
        public virtual ICollection<Matter> Matters { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<PreBillUpload> PreBillUploads { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<WorkDistributionRule> WorkDistributionRules { get; set; }
    }
}
