using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MatterDocument
    {
        public int Id { get; set; }
        public int MatterId { get; set; }
        public int DocumentId { get; set; }

        public virtual Document Document { get; set; }
        public virtual Matter Matter { get; set; }
    }
}
