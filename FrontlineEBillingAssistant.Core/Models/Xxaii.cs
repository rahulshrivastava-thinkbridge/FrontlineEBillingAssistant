using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class Xxaii
    {
        public string Payer { get; set; }
        public string Lawfirm { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? Invoicetotal { get; set; }
        public decimal? Invoicetotalmodified { get; set; }
        public string ChargeDesciption { get; set; }
        public string ChargeDesciptionModified { get; set; }
        public decimal Units { get; set; }
        public decimal UnitsModified { get; set; }
        public decimal? Rate { get; set; }
        public decimal? RateModified { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalAmountModified { get; set; }
        public string TaskCodeModified { get; set; }
        public string TaskActivityCodeModified { get; set; }
        public string Tkcode { get; set; }
        public string LineItemType { get; set; }
        public string RuleCategory { get; set; }
    }
}
