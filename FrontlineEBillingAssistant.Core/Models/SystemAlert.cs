using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class SystemAlert
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int Level { get; set; }
        public string ShortMessage { get; set; }
        public string Message { get; set; }
        public DateTime AlertCreatedTime { get; set; }
    }
}
