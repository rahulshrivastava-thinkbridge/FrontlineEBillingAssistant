using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterUtbmsCodeSetDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhaseCode { get; set; }
        public string PhaseName { get; set; }
        public string PhaseDescription { get; set; }
        public string TaskCode { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int? MasterUtbmsCodeSetId { get; set; }

        public virtual MasterUtbmsCodeSet MasterUtbmsCodeSet { get; set; }
    }
}
