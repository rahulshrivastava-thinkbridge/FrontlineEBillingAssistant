using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ZcAppealStatusChanngedInvoice31jan2020
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public string LawFirm { get; set; }
        public string Payer { get; set; }
        public int? WorkFlowOwnerId { get; set; }
        public string AppealStatusName { get; set; }
        public string Status { get; set; }
        public DateTime? PaidDate { get; set; }
        public DateTime UploadedDate { get; set; }
        public DateTime? InvoiceDate { get; set; }
    }
}
