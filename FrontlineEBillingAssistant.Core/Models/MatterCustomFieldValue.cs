using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MatterCustomFieldValue
    {
        public int Id { get; set; }
        public int MatterId { get; set; }
        public int MatterCustomFieldId { get; set; }
        public string Value { get; set; }

        public virtual Matter Matter { get; set; }
        public virtual MatterCustomField MatterCustomField { get; set; }
    }
}
