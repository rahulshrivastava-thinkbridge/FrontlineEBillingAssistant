using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class RuleSet
    {
        public RuleSet()
        {
            Rules = new HashSet<Rule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? MasterProductLineId { get; set; }
        public int? ClientId { get; set; }
        public int Status { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedTime { get; set; }

        public virtual Client Client { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual MasterProductLine MasterProductLine { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual ICollection<Rule> Rules { get; set; }
    }
}
