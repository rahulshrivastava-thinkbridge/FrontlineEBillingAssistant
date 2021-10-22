using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterReportCategory
    {
        public MasterReportCategory()
        {
            MasterReports = new HashSet<MasterReport>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MasterReport> MasterReports { get; set; }
    }
}
