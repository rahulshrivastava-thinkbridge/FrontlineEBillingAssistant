using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class Log
    {
        public int Id { get; set; }
        public int? EntityId { get; set; }
        public int? Type { get; set; }
        public string Narration { get; set; }
        public DateTime? LogDate { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
