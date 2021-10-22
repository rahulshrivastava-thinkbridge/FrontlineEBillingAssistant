using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class TestTable
    {
        public double? SlNo { get; set; }
        public double? FirmClientMatterId { get; set; }
        public string FirmMatterId { get; set; }
        public string MatterName { get; set; }
        public string LineOfBusiness { get; set; }
        public string Client { get; set; }
        public string FirmClient { get; set; }
        public string Status { get; set; }
    }
}
