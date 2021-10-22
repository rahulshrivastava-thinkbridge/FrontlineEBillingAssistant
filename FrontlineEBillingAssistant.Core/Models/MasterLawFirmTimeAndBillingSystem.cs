using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterLawFirmTimeAndBillingSystem
    {
        public MasterLawFirmTimeAndBillingSystem()
        {
            LawFirms = new HashSet<LawFirm>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<LawFirm> LawFirms { get; set; }
    }
}
