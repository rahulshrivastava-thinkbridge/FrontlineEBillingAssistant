using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcQuery
    {
        public DateTime? DateT { get; set; }
        public string Query { get; set; }
        public string Fromsp { get; set; }
    }
}
