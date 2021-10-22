using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class TimekeeperNote
    {
        public int Id { get; set; }
        public int TimekeeperId { get; set; }
        public string Note { get; set; }
        public DateTime NoteTimeStamp { get; set; }
        public int CreatedById { get; set; }
        public int Status { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual LawFirmContactPerson Timekeeper { get; set; }
    }
}
