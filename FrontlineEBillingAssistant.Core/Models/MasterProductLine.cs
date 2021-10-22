using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterProductLine
    {
        public MasterProductLine()
        {
            ClientInvPrepRates = new HashSet<ClientInvPrepRate>();
            ClientMatterCustomFields = new HashSet<ClientMatterCustomField>();
            LawFirmMatterCustomFields = new HashSet<LawFirmMatterCustomField>();
            Matters = new HashSet<Matter>();
            RuleSets = new HashSet<RuleSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<ClientInvPrepRate> ClientInvPrepRates { get; set; }
        public virtual ICollection<ClientMatterCustomField> ClientMatterCustomFields { get; set; }
        public virtual ICollection<LawFirmMatterCustomField> LawFirmMatterCustomFields { get; set; }
        public virtual ICollection<Matter> Matters { get; set; }
        public virtual ICollection<RuleSet> RuleSets { get; set; }
    }
}
