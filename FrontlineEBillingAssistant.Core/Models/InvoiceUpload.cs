using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class InvoiceUpload
    {
        public int Id { get; set; }
        public int LawFirmId { get; set; }
        public int? ClientId { get; set; }
        public int UserId { get; set; }
        public string InvoiceFileName { get; set; }
        public string InvoiceDocumentFileNames { get; set; }
        public string InvoiceNotes { get; set; }
        public int InvoiceUploadStatusId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string TrackingNumber { get; set; }

        public virtual Client Client { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual User User { get; set; }
    }
}
