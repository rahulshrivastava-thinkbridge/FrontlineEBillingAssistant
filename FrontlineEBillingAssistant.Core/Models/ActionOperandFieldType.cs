using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ActionOperandFieldType
    {
        public int Id { get; set; }
        public int OperandId { get; set; }
        public int FieldTypeId { get; set; }

        public virtual RuleFieldType FieldType { get; set; }
        public virtual ActionOperand Operand { get; set; }
    }
}
