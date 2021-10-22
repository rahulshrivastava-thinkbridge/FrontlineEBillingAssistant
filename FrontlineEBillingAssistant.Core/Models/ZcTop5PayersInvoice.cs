using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcTop5PayersInvoice
    {
        public int InvId { get; set; }
        public string InvNum { get; set; }
        public decimal? Invoicetotal { get; set; }
        public decimal? Invoicetotalmodified { get; set; }
        public int ClientId { get; set; }
        public int LawfirmId { get; set; }
        public string Payer { get; set; }
        public string Lawfirm { get; set; }
        public string LawFirmMappedName { get; set; }
    }
}
