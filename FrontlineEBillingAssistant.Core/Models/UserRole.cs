using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public int MasterRoleId { get; set; }
        public int UserId { get; set; }

        public virtual MasterRole MasterRole { get; set; }
        public virtual User User { get; set; }
    }
}
