using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class TicketResponse
    {
        public TicketResponse()
        {
            TicketCommentAttachments = new HashSet<TicketCommentAttachment>();
        }

        public int Id { get; set; }
        public int TicketId { get; set; }
        public string Comment { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual Ticket Ticket { get; set; }
        public virtual ICollection<TicketCommentAttachment> TicketCommentAttachments { get; set; }
    }
}
