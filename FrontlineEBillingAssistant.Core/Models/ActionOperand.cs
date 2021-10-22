using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ActionOperand
    {
        public ActionOperand()
        {
            ActionOperandFieldTypes = new HashSet<ActionOperandFieldType>();
        }

        public int Id { get; set; }
        public string Operand { get; set; }

        public virtual ICollection<ActionOperandFieldType> ActionOperandFieldTypes { get; set; }
    }
}
