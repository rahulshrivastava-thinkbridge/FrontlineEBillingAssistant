using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoicePrebillMatchLog
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int PrebillId { get; set; }
        public decimal? MatchPercentage { get; set; }
        public string MatchComments { get; set; }
    }
}
