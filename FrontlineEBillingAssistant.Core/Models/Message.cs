using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class Message
    {
        public Message()
        {
            InverseParentMessage = new HashSet<Message>();
            MessageAttachments = new HashSet<MessageAttachment>();
        }

        public int Id { get; set; }
        public int? FromUserId { get; set; }
        public int ToUserId { get; set; }
        public int? ToOrganizationId { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public int? EntityType { get; set; }
        public int? EntityId { get; set; }
        public int MessageType { get; set; }
        public int? ParentMessageId { get; set; }
        public bool HasAttachment { get; set; }
        public DateTime CreatedTime { get; set; }
        public int Status { get; set; }
        public int? InvoiceLineItemId { get; set; }

        public virtual User FromUser { get; set; }
        public virtual InvoiceLineItem InvoiceLineItem { get; set; }
        public virtual Message ParentMessage { get; set; }
        public virtual LawFirm ToOrganization { get; set; }
        public virtual User ToUser { get; set; }
        public virtual ICollection<Message> InverseParentMessage { get; set; }
        public virtual ICollection<MessageAttachment> MessageAttachments { get; set; }
    }
}
