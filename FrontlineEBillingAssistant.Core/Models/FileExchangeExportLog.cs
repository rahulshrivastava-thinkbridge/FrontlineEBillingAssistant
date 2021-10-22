using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class FileExchangeExportLog
    {
        public int Id { get; set; }
        public int? InvoiceId { get; set; }
        public int? InvoiceStatus { get; set; }
        public DateTime? SendDate { get; set; }
    }
}
