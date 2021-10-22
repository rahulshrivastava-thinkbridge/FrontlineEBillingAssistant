using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class TicketCommentAttachment
    {
        public int Id { get; set; }
        public int TicketCommentId { get; set; }
        public string OriginalFileName { get; set; }
        public string SavedFileName { get; set; }

        public virtual TicketResponse TicketComment { get; set; }
    }
}
