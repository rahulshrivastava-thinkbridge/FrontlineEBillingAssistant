using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterUtbmsCodeSet
    {
        public MasterUtbmsCodeSet()
        {
            MasterUtbmsCodeSetDetails = new HashSet<MasterUtbmsCodeSetDetail>();
            Matters = new HashSet<Matter>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool DefaultCode { get; set; }

        public virtual ICollection<MasterUtbmsCodeSetDetail> MasterUtbmsCodeSetDetails { get; set; }
        public virtual ICollection<Matter> Matters { get; set; }
    }
}
