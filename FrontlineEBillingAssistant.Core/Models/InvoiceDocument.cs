using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceDocument
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int DocumentId { get; set; }

        public virtual Document Document { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
