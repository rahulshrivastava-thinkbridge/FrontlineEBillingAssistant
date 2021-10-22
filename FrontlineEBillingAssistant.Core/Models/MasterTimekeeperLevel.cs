using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterTimekeeperLevel
    {
        public MasterTimekeeperLevel()
        {
            LawFirmContactPeople = new HashSet<LawFirmContactPerson>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string TimeKeeperMappingLevel { get; set; }

        public virtual ICollection<LawFirmContactPerson> LawFirmContactPeople { get; set; }
    }
}
