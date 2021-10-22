using System.Collections.Generic;

namespace FrontlineEBillingAssistant.Core.Models
{
    public class InvoiceListingFilterRequest
    {
        public string FilterType { get; set; }
        public string FilterValue { get; set; }
    }
}