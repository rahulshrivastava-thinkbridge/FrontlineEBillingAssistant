using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class PayerNote
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Note { get; set; }
        public DateTime NoteTimeStamp { get; set; }
        public int CreatedById { get; set; }
        public int Status { get; set; }

        public virtual Client Client { get; set; }
    }
}
