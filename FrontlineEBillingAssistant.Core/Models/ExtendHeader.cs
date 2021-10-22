using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ExtendHeader
    {
        public ExtendHeader()
        {
            ExtendData = new HashSet<ExtendData>();
            InvoiceLineItemExtendHeaderExtendHeaders = new HashSet<InvoiceLineItem>();
            InvoiceLineItemExtendHeaderModifiedExtendHeaders = new HashSet<InvoiceLineItem>();
            InvoiceTimekeeperSummaries = new HashSet<InvoiceTimekeeperSummary>();
        }

        public int ExtendHeaderId { get; set; }
        public string Vendor { get; set; }
        public string App { get; set; }
        public string Sequence { get; set; }
        public string Date { get; set; }

        public virtual ICollection<ExtendData> ExtendData { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItemExtendHeaderExtendHeaders { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItemExtendHeaderModifiedExtendHeaders { get; set; }
        public virtual ICollection<InvoiceTimekeeperSummary> InvoiceTimekeeperSummaries { get; set; }
    }
}
