using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterEbillerStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public int? MasterEbillerId { get; set; }

        public virtual MasterEbiller MasterEbiller { get; set; }
    }
}
