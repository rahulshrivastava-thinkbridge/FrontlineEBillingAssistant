using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterReport
    {
        public MasterReport()
        {
            FavouriteReports = new HashSet<FavouriteReport>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsIpsReport { get; set; }
        public bool Status { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string ActionMethod { get; set; }
        public string ReportUrl { get; set; }
        public int? ReportCategoryId { get; set; }
        public int? Location { get; set; }

        public virtual MasterReportCategory ReportCategory { get; set; }
        public virtual ICollection<FavouriteReport> FavouriteReports { get; set; }
    }
}
