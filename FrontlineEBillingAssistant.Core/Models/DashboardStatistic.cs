using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class DashboardStatistic
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Count { get; set; }
        public decimal? Value { get; set; }
        public int Type { get; set; }
        public int MasterRoleId { get; set; }
        public int Status { get; set; }

        public virtual MasterRole MasterRole { get; set; }
    }
}
