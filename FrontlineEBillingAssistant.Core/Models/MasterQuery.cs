using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterQuery
    {
        public int Id { get; set; }
        public string Query { get; set; }
        public bool Status { get; set; }
        public string Code { get; set; }
    }
}
