using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class LossType
    {
        public int LossTypeId { get; set; }
        public int CategoryId { get; set; }
        public string LossTypeName { get; set; }
    }
}
