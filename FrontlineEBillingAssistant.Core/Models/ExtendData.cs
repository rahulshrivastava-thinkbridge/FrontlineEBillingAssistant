using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ExtendData
    {
        public int ExtendDataId { get; set; }
        public int ExtendHeaderId { get; set; }
        public string ExtendName { get; set; }
        public string ExtendValue { get; set; }

        public virtual ExtendHeader ExtendHeader { get; set; }
    }
}
