using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterCurrency
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public bool DefaultCurrency { get; set; }
        public int? MasterCountryId { get; set; }

        public virtual MasterCountry MasterCountry { get; set; }
    }
}
