using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Core.Models
{
    public class BillyFeedbackRetrainingTable
    {
        public int ID { get; set; }
        public int InvoiceID { get; set; }
        public int InvoiceLineItemID { get; set; }
        public string InvoiceDate { get; set; }
        public string UploadedDate { get; set; }
        public string LawFirmID { get; set; }
        public string ClientID { get; set; }
        public string TimekeeperID { get; set; }
        public decimal Units { get; set; }
        public decimal Rate { get; set; }
        public decimal BaseAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string ChargeDescription { get; set; }
        public string TaskCode { get; set; }
        public string TaskExpenseCode { get; set; }
        public string PreparationNotes { get; set; }
        public string MLPreparationNotes { get; set; }
        public decimal AgreedRate { get; set; }
        public bool IsModified { get; set; }
        public bool IsRetrained { get; set; }
        public string ModifiedDateTimeStamp { get; set; }
    }
}
