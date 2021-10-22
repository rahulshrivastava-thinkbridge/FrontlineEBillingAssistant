using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class PrebillToInvoiceTklevelMapping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string TimeKeeperMappingLevel { get; set; }
        public int TimeKeeperMappingLevelEnum { get; set; }
    }
}
