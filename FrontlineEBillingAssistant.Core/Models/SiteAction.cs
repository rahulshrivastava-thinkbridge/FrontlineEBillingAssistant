using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class SiteAction
    {
        public int Id { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string RoleNames { get; set; }
        public bool Status { get; set; }
    }
}
