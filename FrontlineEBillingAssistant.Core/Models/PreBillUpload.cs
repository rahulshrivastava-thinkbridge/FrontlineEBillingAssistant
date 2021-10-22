using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class PreBillUpload
    {
        public int Id { get; set; }
        public int LawFirmId { get; set; }
        public int? ClientId { get; set; }
        public int UserId { get; set; }
        public string PreBillFileName { get; set; }
        public string PreBillDocumentFileNames { get; set; }
        public string PreBillNotes { get; set; }
        public int PreBillUploadStatusId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ReceivedDate { get; set; }

        public virtual Client Client { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual User User { get; set; }
    }
}
