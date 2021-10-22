using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class UserLoginLog
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserLogin { get; set; }
        public DateTime LoginTime { get; set; }

        public virtual User User { get; set; }
    }
}
