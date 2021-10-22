using System.Collections.Generic;

namespace FrontlineEBillingAssistant.Core.Models
{
    public class InvoiceListingPagedRequest
    {
        public int PageIndex { get; set; }
        public int StartRecord { get; set; }
        public int EndRecord {  get; set; }
        public string FilterText { get; set; }
    }
}
