using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterEbiller
    {
        public MasterEbiller()
        {
            LawFirmEbillers = new HashSet<LawFirmEbiller>();
            MasterEbillerStatuses = new HashSet<MasterEbillerStatus>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EbillerFamily { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string AutomationUrl { get; set; }
        public string Port { get; set; }
        public string ExtraInfo1 { get; set; }
        public string ExtraInfo2 { get; set; }
        public string Comments { get; set; }
        public string AutomationId { get; set; }
        public int? IsLineLevelParserAvailable { get; set; }

        public virtual ICollection<LawFirmEbiller> LawFirmEbillers { get; set; }
        public virtual ICollection<MasterEbillerStatus> MasterEbillerStatuses { get; set; }
    }
}
