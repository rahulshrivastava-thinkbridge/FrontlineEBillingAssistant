using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ConditionOperand
    {
        public ConditionOperand()
        {
            OperandFieldTypes = new HashSet<OperandFieldType>();
        }

        public int Id { get; set; }
        public string Operand { get; set; }

        public virtual ICollection<OperandFieldType> OperandFieldTypes { get; set; }
    }
}
