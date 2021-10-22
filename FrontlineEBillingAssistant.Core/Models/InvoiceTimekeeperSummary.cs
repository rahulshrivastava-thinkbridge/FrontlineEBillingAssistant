using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceTimekeeperSummary
    {
        public int Id { get; set; }
        public int InvoiceMatterId { get; set; }
        public int? TimekeeperId { get; set; }
        public string TimekeeperId1 { get; set; }
        public string TimekeeperLastName { get; set; }
        public string TimekeeperFirstName { get; set; }
        public int TimekeeperLevel { get; set; }
        public decimal TimekeeperRate { get; set; }
        public decimal TimekeeperTotalUnits { get; set; }
        public int FileItemNumber { get; set; }
        public int? ExtendHeaderExtendHeaderId { get; set; }

        public virtual ExtendHeader ExtendHeaderExtendHeader { get; set; }
        public virtual InvoiceMatter InvoiceMatter { get; set; }
        public virtual LawFirmContactPerson Timekeeper { get; set; }
    }
}
