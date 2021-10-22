using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class FirmClientHistoricalData
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int LawFirmId { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        public decimal? Prebilled { get; set; }
        public decimal? Ipscorrection { get; set; }
        public decimal? Uploaded { get; set; }
        public decimal? Reduction { get; set; }
        public decimal? CostShare { get; set; }
        public decimal? PromptDiscounts { get; set; }
        public decimal? Approved { get; set; }
        public decimal? Appeal { get; set; }
        public decimal? Net { get; set; }
        public decimal? Adjustments { get; set; }
        public decimal? Final { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public decimal? PostAppealReductionRate { get; set; }
        public decimal? AppealSuccessRate { get; set; }

        public virtual Client Client { get; set; }
        public virtual LawFirm LawFirm { get; set; }
    }
}
