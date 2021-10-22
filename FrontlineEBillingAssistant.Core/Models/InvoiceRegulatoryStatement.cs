using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceRegulatoryStatement
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int FileItemNumber { get; set; }
        public string Heading { get; set; }
        public string Statement { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
