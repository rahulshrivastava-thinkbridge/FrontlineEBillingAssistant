using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class RuleCategory
    {
        public RuleCategory()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
            Rules = new HashSet<Rule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public bool? IsShowInDdl { get; set; }

        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual ICollection<Rule> Rules { get; set; }
    }
}
