using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class LawFirmRate
    {
        public int Id { get; set; }
        public int LawFirmId { get; set; }
        public decimal? Associate { get; set; }
        public decimal? Partner { get; set; }
        public decimal? OfCounsel { get; set; }
        public decimal? Paralegal { get; set; }
        public decimal? LegalAssistant { get; set; }
        public decimal? Secretary { get; set; }
        public decimal? Clerk { get; set; }
        public DateTime? RateFrom { get; set; }
        public int? ClientId { get; set; }
        public int? ProductLineId { get; set; }
        public decimal? SeniorPartner { get; set; }
        public decimal? SeniorAssociate { get; set; }

        public virtual Client Client { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual MasterProductLine ProductLine { get; set; }
    }
}
