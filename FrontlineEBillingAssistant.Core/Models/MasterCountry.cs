using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterCountry
    {
        public MasterCountry()
        {
            MasterCurrencies = new HashSet<MasterCurrency>();
            MasterStates = new HashSet<MasterState>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public bool DefaultCountry { get; set; }

        public virtual ICollection<MasterCurrency> MasterCurrencies { get; set; }
        public virtual ICollection<MasterState> MasterStates { get; set; }
    }
}
