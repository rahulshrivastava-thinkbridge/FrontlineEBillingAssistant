using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class TicketAttachment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string OriginalFileName { get; set; }
        public string SavedFileName { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
