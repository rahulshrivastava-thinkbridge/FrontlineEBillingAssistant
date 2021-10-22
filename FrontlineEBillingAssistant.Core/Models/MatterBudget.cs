using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MatterBudget
    {
        public MatterBudget()
        {
            MatterBudgetLines = new HashSet<MatterBudgetLine>();
        }

        public int Id { get; set; }
        public int MatterId { get; set; }
        public decimal? Fees { get; set; }
        public decimal? Expense { get; set; }
        public DateTime? Date { get; set; }
        public int Status { get; set; }
        public int CreatedById { get; set; }
        public string Description { get; set; }
        public decimal? PreIpsfeesBilled { get; set; }
        public decimal? PreIpsexpenseBilled { get; set; }
        public decimal? PreIpstotalBilled { get; set; }
        public decimal? Total { get; set; }
        public int? TypeOfBudget { get; set; }
        public string EbillerReference1 { get; set; }
        public string EbillerReference2 { get; set; }
        public string EbillerStatus { get; set; }
        public string EbillerStatusComments { get; set; }
        public DateTime? EbillerStatusCheckDate { get; set; }
        public DateTime? EbillerStatusChangeDate { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual Matter Matter { get; set; }
        public virtual ICollection<MatterBudgetLine> MatterBudgetLines { get; set; }
    }
}
