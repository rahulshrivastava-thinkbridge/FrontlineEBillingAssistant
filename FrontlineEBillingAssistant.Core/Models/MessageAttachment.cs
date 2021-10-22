using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MessageAttachment
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public string OriginalFileName { get; set; }
        public string SavedFileName { get; set; }

        public virtual Message Message { get; set; }
    }
}
