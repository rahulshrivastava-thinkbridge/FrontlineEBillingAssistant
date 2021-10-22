using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceLog
    {
        public int Id { get; set; }
        public int? InvoiceId { get; set; }
        public int? UserId { get; set; }
        public string Narration { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual User User { get; set; }
    }
}
