using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ParamsGetDashboardClientWiseReductionDrillDown
    {
        public int? LawFirmId { get; set; }
        public int? MonthId { get; set; }
        public int? YearId { get; set; }
        public int? ClientId { get; set; }
        public string Status { get; set; }
        public int? PageIndex { get; set; }
        public int? PageSize { get; set; }
        public string SortOrder { get; set; }
        public string SortDirection { get; set; }
        public string StrQuery { get; set; }
    }
}
