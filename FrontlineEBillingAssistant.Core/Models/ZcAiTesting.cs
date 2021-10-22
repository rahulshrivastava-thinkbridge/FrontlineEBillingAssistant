using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcAiTesting
    {
        public int Id { get; set; }
        public int InvId { get; set; }
        public DateTime Uploadeddate { get; set; }
        public int Lineid { get; set; }
        public int ClientId { get; set; }
        public string ChargeDesciption { get; set; }
        public decimal? Rate { get; set; }
        public decimal Units { get; set; }
        public bool IsModified { get; set; }
        public int RuleId { get; set; }
        public string CategoryName { get; set; }
    }
}
