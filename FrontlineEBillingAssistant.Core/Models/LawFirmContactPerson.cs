using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class LawFirmContactPerson
    {
        public LawFirmContactPerson()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
            InvoiceTimekeeperSummaries = new HashSet<InvoiceTimekeeperSummary>();
            LawFirmDefaultExpenseQueryCopyContactPeople = new HashSet<LawFirm>();
            LawFirmDefaultFeeQueryCopyContactPeople = new HashSet<LawFirm>();
            MatterLawFirmContacts = new HashSet<MatterLawFirmContact>();
            MatterTimekeepers = new HashSet<MatterTimekeeper>();
            TimekeeperNotes = new HashSet<TimekeeperNote>();
        }

        public int Id { get; set; }
        public int LawFirmId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Cell { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int? UserId { get; set; }
        public int StatusId { get; set; }
        public string BillingCode { get; set; }
        public int? MasterTimekeeperLevelId { get; set; }
        public string Discriminator { get; set; }
        public bool IsQueryContact { get; set; }
        public string EbillerReference1 { get; set; }
        public string EbillerReference2 { get; set; }
        public string EbillerStatus { get; set; }
        public string EbillerStatusComments { get; set; }
        public DateTime? EbillerStatusCheckDate { get; set; }
        public DateTime? EbillerStatusChangeDate { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual MasterTimekeeperLevel MasterTimekeeperLevel { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual ICollection<InvoiceTimekeeperSummary> InvoiceTimekeeperSummaries { get; set; }
        public virtual ICollection<LawFirm> LawFirmDefaultExpenseQueryCopyContactPeople { get; set; }
        public virtual ICollection<LawFirm> LawFirmDefaultFeeQueryCopyContactPeople { get; set; }
        public virtual ICollection<MatterLawFirmContact> MatterLawFirmContacts { get; set; }
        public virtual ICollection<MatterTimekeeper> MatterTimekeepers { get; set; }
        public virtual ICollection<TimekeeperNote> TimekeeperNotes { get; set; }
    }
}
