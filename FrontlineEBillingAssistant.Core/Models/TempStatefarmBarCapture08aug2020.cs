using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class TempStatefarmBarCapture08aug2020
    {
        public int InvId { get; set; }
        public string InvoiceNum { get; set; }
        public decimal? OrigInvoiceTotal { get; set; }
        public decimal? ModInvoiceTotal { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string StatusName { get; set; }
        public string ClientMatterIdModified { get; set; }
        public bool LineLevelDataProcessed { get; set; }
    }
}
