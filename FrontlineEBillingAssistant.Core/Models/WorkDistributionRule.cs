using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class WorkDistributionRule
    {
        public WorkDistributionRule()
        {
            WorkDistributionRuleUsers = new HashSet<WorkDistributionRuleUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ClientId { get; set; }
        public int? LawFirmId { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public int? InvoiceTotalCondition { get; set; }
        public int? ClientCondition { get; set; }
        public int? LawFirmCondition { get; set; }
        public short? AllocationPolicy { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int? RuleOrder { get; set; }
        public int Status { get; set; }

        public virtual Client Client { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual ICollection<WorkDistributionRuleUser> WorkDistributionRuleUsers { get; set; }
    }
}
