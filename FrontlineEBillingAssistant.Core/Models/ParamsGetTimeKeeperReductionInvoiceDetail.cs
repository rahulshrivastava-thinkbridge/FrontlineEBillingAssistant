using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ParamsGetTimeKeeperReductionInvoiceDetail
    {
        public int? LawFirmId { get; set; }
        public int? TimekeeperId { get; set; }
        public int? ClientId { get; set; }
        public string Category { get; set; }
        public int? PageSize { get; set; }
        public int? PageNumber { get; set; }
        public string SortOrder { get; set; }
        public string SortDirection { get; set; }
        public string Status { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string StrQuery { get; set; }
    }
}
