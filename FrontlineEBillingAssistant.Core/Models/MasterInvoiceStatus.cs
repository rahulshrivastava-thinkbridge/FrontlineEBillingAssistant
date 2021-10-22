using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterInvoiceStatus
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int DisplayOrder { get; set; }
    }
}
