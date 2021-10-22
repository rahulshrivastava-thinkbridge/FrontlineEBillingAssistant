using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class SystemTaskNote
    {
        public int Id { get; set; }
        public int SystemTaskId { get; set; }
        public string Note { get; set; }
        public int? UserId { get; set; }
        public string FileName { get; set; }
        public string LogicalFileName { get; set; }
        public DateTime NoteTimestamp { get; set; }

        public virtual SystemTask SystemTask { get; set; }
    }
}
