using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class Client
    {
        public Client()
        {
            AllocationRules = new HashSet<AllocationRule>();
            ApprovalRules = new HashSet<ApprovalRule>();
            ClientAddresses = new HashSet<ClientAddress>();
            ClientDocuments = new HashSet<ClientDocument>();
            ClientInvPrepRates = new HashSet<ClientInvPrepRate>();
            ClientMatterCustomFields = new HashSet<ClientMatterCustomField>();
            FirmClientHistoricalData = new HashSet<FirmClientHistoricalData>();
            FirmClientHistoricalDataLogs = new HashSet<FirmClientHistoricalDataLog>();
            InvoiceClients = new HashSet<InvoiceClient>();
            InvoiceUploads = new HashSet<InvoiceUpload>();
            LawfirmClients = new HashSet<LawfirmClient>();
            Matters = new HashSet<Matter>();
            PayerDocuments = new HashSet<PayerDocument>();
            PayerNotes = new HashSet<PayerNote>();
            PreBillUploads = new HashSet<PreBillUpload>();
            RuleSets = new HashSet<RuleSet>();
            WorkDistributionRules = new HashSet<WorkDistributionRule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int? CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string TaxId { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Tel { get; set; }
        public string PrintName { get; set; }
        public int DaysToAppeal { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual ICollection<AllocationRule> AllocationRules { get; set; }
        public virtual ICollection<ApprovalRule> ApprovalRules { get; set; }
        public virtual ICollection<ClientAddress> ClientAddresses { get; set; }
        public virtual ICollection<ClientDocument> ClientDocuments { get; set; }
        public virtual ICollection<ClientInvPrepRate> ClientInvPrepRates { get; set; }
        public virtual ICollection<ClientMatterCustomField> ClientMatterCustomFields { get; set; }
        public virtual ICollection<FirmClientHistoricalData> FirmClientHistoricalData { get; set; }
        public virtual ICollection<FirmClientHistoricalDataLog> FirmClientHistoricalDataLogs { get; set; }
        public virtual ICollection<InvoiceClient> InvoiceClients { get; set; }
        public virtual ICollection<InvoiceUpload> InvoiceUploads { get; set; }
        public virtual ICollection<LawfirmClient> LawfirmClients { get; set; }
        public virtual ICollection<Matter> Matters { get; set; }
        public virtual ICollection<PayerDocument> PayerDocuments { get; set; }
        public virtual ICollection<PayerNote> PayerNotes { get; set; }
        public virtual ICollection<PreBillUpload> PreBillUploads { get; set; }
        public virtual ICollection<RuleSet> RuleSets { get; set; }
        public virtual ICollection<WorkDistributionRule> WorkDistributionRules { get; set; }
    }
}
