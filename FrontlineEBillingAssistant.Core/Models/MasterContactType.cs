using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterContactType
    {
        public MasterContactType()
        {
            MatterClientContacts = new HashSet<MatterClientContact>();
            MatterLawFirmContacts = new HashSet<MatterLawFirmContact>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EntityType { get; set; }

        public virtual ICollection<MatterClientContact> MatterClientContacts { get; set; }
        public virtual ICollection<MatterLawFirmContact> MatterLawFirmContacts { get; set; }
    }
}
