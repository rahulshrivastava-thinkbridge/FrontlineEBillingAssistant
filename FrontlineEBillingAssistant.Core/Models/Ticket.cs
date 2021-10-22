using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class Ticket
    {
        public Ticket()
        {
            TicketAttachments = new HashSet<TicketAttachment>();
            TicketResponses = new HashSet<TicketResponse>();
        }

        public int Id { get; set; }
        public string TicketNo { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int TicketAreaId { get; set; }
        public int RaisedById { get; set; }
        public DateTime RaisedDate { get; set; }
        public int? ResolvedById { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public DateTime? AssignedDate { get; set; }
        public int? AssignedToId { get; set; }
        public int? AssignedById { get; set; }
        public int Status { get; set; }

        public virtual User AssignedBy { get; set; }
        public virtual User AssignedTo { get; set; }
        public virtual User RaisedBy { get; set; }
        public virtual User ResolvedBy { get; set; }
        public virtual MasterTicketArea TicketArea { get; set; }
        public virtual ICollection<TicketAttachment> TicketAttachments { get; set; }
        public virtual ICollection<TicketResponse> TicketResponses { get; set; }
    }
}
