using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceFile
    {
        public InvoiceFile()
        {
            InvoiceFirms = new HashSet<InvoiceFirm>();
            InvoiceTaxes = new HashSet<InvoiceTaxis>();
            SystemTasks = new HashSet<SystemTask>();
        }

        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int InputFormatId { get; set; }
        public string InvoiceFileType { get; set; }

        public virtual ICollection<InvoiceFirm> InvoiceFirms { get; set; }
        public virtual ICollection<InvoiceTaxis> InvoiceTaxes { get; set; }
        public virtual ICollection<SystemTask> SystemTasks { get; set; }
    }
}
