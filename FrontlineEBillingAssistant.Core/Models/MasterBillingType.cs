using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterBillingType
    {
        public MasterBillingType()
        {
            Matters = new HashSet<Matter>();
        }

        public int Id { get; set; }
        public string BillingCode { get; set; }
        public bool IsDefault { get; set; }

        public virtual ICollection<Matter> Matters { get; set; }
    }
}
