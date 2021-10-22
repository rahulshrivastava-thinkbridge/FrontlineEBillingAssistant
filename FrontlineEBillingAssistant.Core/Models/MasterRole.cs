using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterRole
    {
        public MasterRole()
        {
            DashboardStatistics = new HashSet<DashboardStatistic>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public bool IsIpsuser { get; set; }

        public virtual ICollection<DashboardStatistic> DashboardStatistics { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
