using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Core.Models
{
    public class InvoiceListingGridModel
    {
        public int InvoiceId { get; set; }
        public string UploadedDate { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string LawFirmName { get; set; }
        public string FirmMatterId { get; set; }
        public string ClientName { get; set; }
        public string ClientMatterId { get; set; }
        public string MatterName { get; set; }
        public string OriginalTotal { get; set; }
        public string ModifiedTotal { get; set; }
        public string Status { get; set; }
        public string MLStatus { get; set; }
        public string AppealStatus { get; set; }
        public string AppealDeadlineDate { get; set; }
        public string Preparer { get; set; }
        public string WorkFlowOwner { get; set; }
        public string Action { get; set; }
    }
}
