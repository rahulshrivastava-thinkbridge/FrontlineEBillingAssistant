using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterUserStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
    }
}
