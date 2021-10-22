using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcTop4PayersRedInvoice
    {
        public int Id { get; set; }
        public string Invoicecode { get; set; }
        public decimal? Invoicetotal { get; set; }
        public decimal? Invoicetotalmodified { get; set; }
        public int? ClientId { get; set; }
        public string Payer { get; set; }
        public string LawFirm { get; set; }
    }
}
