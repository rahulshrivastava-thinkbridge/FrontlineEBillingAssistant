using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ReportSelectedColumn
    {
        public int Id { get; set; }
        public int? ColumnId { get; set; }
        public int? UserId { get; set; }
        public int? ReportId { get; set; }
    }
}
