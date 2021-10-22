using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class TrackingMenuItem
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public int LawFirmId { get; set; }
    }
}
