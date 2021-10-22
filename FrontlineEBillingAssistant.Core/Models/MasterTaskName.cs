using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterTaskName
    {
        public string TaskName { get; set; }
        public string DisplayName { get; set; }
        public int DisplayOrder { get; set; }
    }
}
