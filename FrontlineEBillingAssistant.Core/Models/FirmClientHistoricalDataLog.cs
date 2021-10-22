using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class FirmClientHistoricalDataLog
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int LawFirmId { get; set; }
        public string Narration { get; set; }
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual Client Client { get; set; }
        public virtual LawFirm LawFirm { get; set; }
    }
}
