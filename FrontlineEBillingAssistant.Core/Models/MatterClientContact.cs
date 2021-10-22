using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MatterClientContact
    {
        public int Id { get; set; }
        public int MatterId { get; set; }
        public int ClientContactId { get; set; }
        public int MasterContactTypeId { get; set; }

        public virtual ClientContact ClientContact { get; set; }
        public virtual MasterContactType MasterContactType { get; set; }
        public virtual Matter Matter { get; set; }
    }
}
