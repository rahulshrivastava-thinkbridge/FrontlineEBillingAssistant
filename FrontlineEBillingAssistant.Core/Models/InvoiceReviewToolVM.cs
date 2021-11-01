using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Core.Models
{
    public class InvoiceReviewToolVM
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string InvoiceFormat { get; set; }
        public bool IsFinal { get; set; }
        public string Tags { get; set; }
        public string RuleCode { get; set; }
    }
}
