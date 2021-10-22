using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class CustomField
    {
        public int Id { get; set; }
        public string ExtendName { get; set; }
        public string ExtendValue { get; set; }
        public string ExtendAddlValue { get; set; }
        public int Order { get; set; }
        public int? InvoiceId { get; set; }
        public int? InvoiceMatterId { get; set; }
        public string Discriminator { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual InvoiceMatter InvoiceMatter { get; set; }
    }
}
