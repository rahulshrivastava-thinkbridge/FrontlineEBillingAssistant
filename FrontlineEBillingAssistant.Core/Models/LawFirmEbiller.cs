using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class LawFirmEbiller
    {
        public LawFirmEbiller()
        {
            LawfirmClients = new HashSet<LawfirmClient>();
        }

        public int Id { get; set; }
        public int LawFirmId { get; set; }
        public int MasterEbillerId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ExtraInfo1 { get; set; }
        public string ExtraInfo2 { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreatedById { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int Status { get; set; }
        public string LoginStatus { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual MasterEbiller MasterEbiller { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual ICollection<LawfirmClient> LawfirmClients { get; set; }
    }
}
