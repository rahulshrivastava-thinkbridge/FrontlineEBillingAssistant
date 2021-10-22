using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class PreBillCorrectionReportDetail
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string ReportDisplayName { get; set; }
        public string ReportOriginalName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
