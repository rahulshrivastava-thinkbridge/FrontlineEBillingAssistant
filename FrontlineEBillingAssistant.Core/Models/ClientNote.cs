using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ClientNote
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Note { get; set; }
        public DateTime NoteTimeStamp { get; set; }
        public int CreatedById { get; set; }
        public int Status { get; set; }
        public bool IsPrivate { get; set; }

        public virtual LawfirmClient Client { get; set; }
    }
}
