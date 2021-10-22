using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MatterException
    {
        public int Id { get; set; }
        public int MatterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int? RuleId { get; set; }
        public bool IsPeriodSpecific { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual Matter Matter { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual Rule Rule { get; set; }
    }
}
