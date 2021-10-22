using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class RuleFieldType
    {
        public RuleFieldType()
        {
            ActionOperandFieldTypes = new HashSet<ActionOperandFieldType>();
            OperandFieldTypes = new HashSet<OperandFieldType>();
        }

        public int Id { get; set; }
        public string FieldType { get; set; }

        public virtual ICollection<ActionOperandFieldType> ActionOperandFieldTypes { get; set; }
        public virtual ICollection<OperandFieldType> OperandFieldTypes { get; set; }
    }
}
