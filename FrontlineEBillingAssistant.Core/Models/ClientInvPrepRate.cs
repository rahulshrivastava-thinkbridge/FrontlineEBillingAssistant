using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ClientInvPrepRate
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int MasterProductLineId { get; set; }
        public decimal InvPrepRate { get; set; }
        public decimal? TaxRate { get; set; }
        public bool Status { get; set; }
        public decimal? InvPrepExpRate { get; set; }
        public int? LawFirmId { get; set; }

        public virtual Client Client { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual MasterProductLine MasterProductLine { get; set; }
    }
}
