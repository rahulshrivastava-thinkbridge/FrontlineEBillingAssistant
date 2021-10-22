using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MatterTimekeeper
    {
        public int Id { get; set; }
        public int TimekeeperId { get; set; }
        public int MatterId { get; set; }
        public int Status { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? RateFrom { get; set; }

        public virtual Matter Matter { get; set; }
        public virtual LawFirmContactPerson Timekeeper { get; set; }
    }
}
