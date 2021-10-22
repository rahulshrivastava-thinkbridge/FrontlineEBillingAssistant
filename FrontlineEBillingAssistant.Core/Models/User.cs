using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class User
    {
        public User()
        {
            AllocationRuleAllocatedTos = new HashSet<AllocationRule>();
            AllocationRuleCreatedBies = new HashSet<AllocationRule>();
            AllocationRuleModifiedBies = new HashSet<AllocationRule>();
            AppealRuleCreatedBies = new HashSet<AppealRule>();
            AppealRuleModifiedBies = new HashSet<AppealRule>();
            ApprovalRuleApprovers = new HashSet<ApprovalRule>();
            ApprovalRuleCreatedBies = new HashSet<ApprovalRule>();
            ApprovalRuleModifiedBies = new HashSet<ApprovalRule>();
            ApprovalRulePreparers = new HashSet<ApprovalRule>();
            ApprovalRuleSecondApprovers = new HashSet<ApprovalRule>();
            ApprovalRuleThirdApprovers = new HashSet<ApprovalRule>();
            ClientApprovers = new HashSet<ClientApprover>();
            ClientCreatedBies = new HashSet<Client>();
            ClientMatterCustomFieldCreatedBies = new HashSet<ClientMatterCustomField>();
            ClientMatterCustomFieldModifiedBies = new HashSet<ClientMatterCustomField>();
            ClientModifiedBies = new HashSet<Client>();
            Documents = new HashSet<Document>();
            InvPrepInvoices = new HashSet<InvPrepInvoice>();
            InverseCreatedBy = new HashSet<User>();
            InverseModifiedBy = new HashSet<User>();
            InvoiceApprovedBies = new HashSet<Invoice>();
            InvoiceAssignedToUsers = new HashSet<Invoice>();
            InvoiceCreatedBies = new HashSet<Invoice>();
            InvoiceExportedBies = new HashSet<Invoice>();
            InvoiceNotes = new HashSet<InvoiceNote>();
            InvoicePreparedByUsers = new HashSet<Invoice>();
            InvoiceUploads = new HashSet<InvoiceUpload>();
            InvoiceWorkFlowOwners = new HashSet<Invoice>();
            LawFirmContactPersonCreatedBies = new HashSet<LawFirmContactPerson>();
            LawFirmContactPersonModifiedBies = new HashSet<LawFirmContactPerson>();
            LawFirmContactPersonUsers = new HashSet<LawFirmContactPerson>();
            LawFirmCreatedBies = new HashSet<LawFirm>();
            LawFirmDefaultExpenseQueryCopyUsers = new HashSet<LawFirm>();
            LawFirmDefaultExpenseQueryUsers = new HashSet<LawFirm>();
            LawFirmDefaultFeeQueryCopyUsers = new HashSet<LawFirm>();
            LawFirmDefaultFeeQueryUsers = new HashSet<LawFirm>();
            LawFirmEbillerCreatedBies = new HashSet<LawFirmEbiller>();
            LawFirmEbillerModifiedBies = new HashSet<LawFirmEbiller>();
            LawFirmMatterCustomFieldCreatedBies = new HashSet<LawFirmMatterCustomField>();
            LawFirmMatterCustomFieldModifiedBies = new HashSet<LawFirmMatterCustomField>();
            LawFirmModifiedBies = new HashSet<LawFirm>();
            LawFirmNotes = new HashSet<LawFirmNote>();
            LawFirmOfficeCreatedBies = new HashSet<LawFirmOffice>();
            LawFirmOfficeModifiedBies = new HashSet<LawFirmOffice>();
            LawfirmClientCreatedBies = new HashSet<LawfirmClient>();
            LawfirmClientModifiedBies = new HashSet<LawfirmClient>();
            LineItemCommunicationAddressedToUsers = new HashSet<LineItemCommunication>();
            LineItemCommunicationWrittenByUsers = new HashSet<LineItemCommunication>();
            Logs = new HashSet<Log>();
            MasterDocumentCategoryCreatedBies = new HashSet<MasterDocumentCategory>();
            MasterDocumentCategoryModifiedBies = new HashSet<MasterDocumentCategory>();
            MatterBudgets = new HashSet<MatterBudget>();
            MatterCreatedBies = new HashSet<Matter>();
            MatterCustomFieldCreatedBies = new HashSet<MatterCustomField>();
            MatterCustomFieldModifiedBies = new HashSet<MatterCustomField>();
            MatterExceptionCreatedBies = new HashSet<MatterException>();
            MatterExceptionModifiedBies = new HashSet<MatterException>();
            MatterModifiedBies = new HashSet<Matter>();
            MatterNotes = new HashSet<MatterNote>();
            MessageFromUsers = new HashSet<Message>();
            MessageToUsers = new HashSet<Message>();
            PreBillUploads = new HashSet<PreBillUpload>();
            RuleCreatedBies = new HashSet<Rule>();
            RuleModifiedBies = new HashSet<Rule>();
            RuleSetCreatedBies = new HashSet<RuleSet>();
            RuleSetModifiedBies = new HashSet<RuleSet>();
            SystemTasks = new HashSet<SystemTask>();
            TicketAssignedBies = new HashSet<Ticket>();
            TicketAssignedTos = new HashSet<Ticket>();
            TicketRaisedBies = new HashSet<Ticket>();
            TicketResolvedBies = new HashSet<Ticket>();
            TicketResponses = new HashSet<TicketResponse>();
            TimekeeperNotes = new HashSet<TimekeeperNote>();
            UserLoginLogs = new HashSet<UserLoginLog>();
            UserRoles = new HashSet<UserRole>();
            WorkDistributionRuleCreatedBies = new HashSet<WorkDistributionRule>();
            WorkDistributionRuleModifiedBies = new HashSet<WorkDistributionRule>();
            WorkDistributionRuleUsers = new HashSet<WorkDistributionRuleUser>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? LawFirmId { get; set; }
        public int CreatedById { get; set; }
        public int ModifiedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int Status { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual ICollection<AllocationRule> AllocationRuleAllocatedTos { get; set; }
        public virtual ICollection<AllocationRule> AllocationRuleCreatedBies { get; set; }
        public virtual ICollection<AllocationRule> AllocationRuleModifiedBies { get; set; }
        public virtual ICollection<AppealRule> AppealRuleCreatedBies { get; set; }
        public virtual ICollection<AppealRule> AppealRuleModifiedBies { get; set; }
        public virtual ICollection<ApprovalRule> ApprovalRuleApprovers { get; set; }
        public virtual ICollection<ApprovalRule> ApprovalRuleCreatedBies { get; set; }
        public virtual ICollection<ApprovalRule> ApprovalRuleModifiedBies { get; set; }
        public virtual ICollection<ApprovalRule> ApprovalRulePreparers { get; set; }
        public virtual ICollection<ApprovalRule> ApprovalRuleSecondApprovers { get; set; }
        public virtual ICollection<ApprovalRule> ApprovalRuleThirdApprovers { get; set; }
        public virtual ICollection<ClientApprover> ClientApprovers { get; set; }
        public virtual ICollection<Client> ClientCreatedBies { get; set; }
        public virtual ICollection<ClientMatterCustomField> ClientMatterCustomFieldCreatedBies { get; set; }
        public virtual ICollection<ClientMatterCustomField> ClientMatterCustomFieldModifiedBies { get; set; }
        public virtual ICollection<Client> ClientModifiedBies { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<InvPrepInvoice> InvPrepInvoices { get; set; }
        public virtual ICollection<User> InverseCreatedBy { get; set; }
        public virtual ICollection<User> InverseModifiedBy { get; set; }
        public virtual ICollection<Invoice> InvoiceApprovedBies { get; set; }
        public virtual ICollection<Invoice> InvoiceAssignedToUsers { get; set; }
        public virtual ICollection<Invoice> InvoiceCreatedBies { get; set; }
        public virtual ICollection<Invoice> InvoiceExportedBies { get; set; }
        public virtual ICollection<InvoiceNote> InvoiceNotes { get; set; }
        public virtual ICollection<Invoice> InvoicePreparedByUsers { get; set; }
        public virtual ICollection<InvoiceUpload> InvoiceUploads { get; set; }
        public virtual ICollection<Invoice> InvoiceWorkFlowOwners { get; set; }
        public virtual ICollection<LawFirmContactPerson> LawFirmContactPersonCreatedBies { get; set; }
        public virtual ICollection<LawFirmContactPerson> LawFirmContactPersonModifiedBies { get; set; }
        public virtual ICollection<LawFirmContactPerson> LawFirmContactPersonUsers { get; set; }
        public virtual ICollection<LawFirm> LawFirmCreatedBies { get; set; }
        public virtual ICollection<LawFirm> LawFirmDefaultExpenseQueryCopyUsers { get; set; }
        public virtual ICollection<LawFirm> LawFirmDefaultExpenseQueryUsers { get; set; }
        public virtual ICollection<LawFirm> LawFirmDefaultFeeQueryCopyUsers { get; set; }
        public virtual ICollection<LawFirm> LawFirmDefaultFeeQueryUsers { get; set; }
        public virtual ICollection<LawFirmEbiller> LawFirmEbillerCreatedBies { get; set; }
        public virtual ICollection<LawFirmEbiller> LawFirmEbillerModifiedBies { get; set; }
        public virtual ICollection<LawFirmMatterCustomField> LawFirmMatterCustomFieldCreatedBies { get; set; }
        public virtual ICollection<LawFirmMatterCustomField> LawFirmMatterCustomFieldModifiedBies { get; set; }
        public virtual ICollection<LawFirm> LawFirmModifiedBies { get; set; }
        public virtual ICollection<LawFirmNote> LawFirmNotes { get; set; }
        public virtual ICollection<LawFirmOffice> LawFirmOfficeCreatedBies { get; set; }
        public virtual ICollection<LawFirmOffice> LawFirmOfficeModifiedBies { get; set; }
        public virtual ICollection<LawfirmClient> LawfirmClientCreatedBies { get; set; }
        public virtual ICollection<LawfirmClient> LawfirmClientModifiedBies { get; set; }
        public virtual ICollection<LineItemCommunication> LineItemCommunicationAddressedToUsers { get; set; }
        public virtual ICollection<LineItemCommunication> LineItemCommunicationWrittenByUsers { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<MasterDocumentCategory> MasterDocumentCategoryCreatedBies { get; set; }
        public virtual ICollection<MasterDocumentCategory> MasterDocumentCategoryModifiedBies { get; set; }
        public virtual ICollection<MatterBudget> MatterBudgets { get; set; }
        public virtual ICollection<Matter> MatterCreatedBies { get; set; }
        public virtual ICollection<MatterCustomField> MatterCustomFieldCreatedBies { get; set; }
        public virtual ICollection<MatterCustomField> MatterCustomFieldModifiedBies { get; set; }
        public virtual ICollection<MatterException> MatterExceptionCreatedBies { get; set; }
        public virtual ICollection<MatterException> MatterExceptionModifiedBies { get; set; }
        public virtual ICollection<Matter> MatterModifiedBies { get; set; }
        public virtual ICollection<MatterNote> MatterNotes { get; set; }
        public virtual ICollection<Message> MessageFromUsers { get; set; }
        public virtual ICollection<Message> MessageToUsers { get; set; }
        public virtual ICollection<PreBillUpload> PreBillUploads { get; set; }
        public virtual ICollection<Rule> RuleCreatedBies { get; set; }
        public virtual ICollection<Rule> RuleModifiedBies { get; set; }
        public virtual ICollection<RuleSet> RuleSetCreatedBies { get; set; }
        public virtual ICollection<RuleSet> RuleSetModifiedBies { get; set; }
        public virtual ICollection<SystemTask> SystemTasks { get; set; }
        public virtual ICollection<Ticket> TicketAssignedBies { get; set; }
        public virtual ICollection<Ticket> TicketAssignedTos { get; set; }
        public virtual ICollection<Ticket> TicketRaisedBies { get; set; }
        public virtual ICollection<Ticket> TicketResolvedBies { get; set; }
        public virtual ICollection<TicketResponse> TicketResponses { get; set; }
        public virtual ICollection<TimekeeperNote> TimekeeperNotes { get; set; }
        public virtual ICollection<UserLoginLog> UserLoginLogs { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<WorkDistributionRule> WorkDistributionRuleCreatedBies { get; set; }
        public virtual ICollection<WorkDistributionRule> WorkDistributionRuleModifiedBies { get; set; }
        public virtual ICollection<WorkDistributionRuleUser> WorkDistributionRuleUsers { get; set; }
    }
}
