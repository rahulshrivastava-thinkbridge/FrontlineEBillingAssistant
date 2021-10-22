using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MatterLawFirmContact
    {
        public int Id { get; set; }
        public int MatterId { get; set; }
        public int LawFirmContactPersonId { get; set; }
        public int MasterContactTypeId { get; set; }

        public virtual LawFirmContactPerson LawFirmContactPerson { get; set; }
        public virtual MasterContactType MasterContactType { get; set; }
        public virtual Matter Matter { get; set; }
    }
}
