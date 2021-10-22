using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class DashboardArtrackingMonthly
    {
        public long? Row { get; set; }
        public string Payer { get; set; }
        public decimal? NetReceivable { get; set; }
        public decimal? Writeoff { get; set; }
        public decimal? PendingWriteOff { get; set; }
    }
}
