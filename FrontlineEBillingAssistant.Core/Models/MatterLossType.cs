using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MatterLossType
    {
        public int Id { get; set; }
        public int MatterId { get; set; }
        public int LossTypeId { get; set; }
    }
}
