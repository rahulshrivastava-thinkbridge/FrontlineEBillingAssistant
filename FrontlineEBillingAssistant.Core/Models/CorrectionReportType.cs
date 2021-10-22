using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class CorrectionReportType
    {
        public int Id { get; set; }
        public string BillType { get; set; }
        public string ReportName { get; set; }
        public string ReportFileName { get; set; }
        public string HelpNote { get; set; }
    }
}
