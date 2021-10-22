using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class LawfirmInvoiceUpload
    {
        public int Id { get; set; }
        public int? LawFirmId { get; set; }
        public int? ClientId { get; set; }
        public int? UserId { get; set; }
        public string InvoiceFileName { get; set; }
        public string InvoiceDocumentFileNames { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? InvoiceUploadStatusId { get; set; }
    }
}
