using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class WanekLibertyTimekeeperRate
    {
        public int Id { get; set; }
        public int TimekeeperId { get; set; }
        public string BillingCode { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? RateFrom { get; set; }
        public int? ClientId { get; set; }
        public int? ProductLineId { get; set; }
        public string Note { get; set; }
    }
}
