using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class PendingInvoiceApprovalNotification
    {
        public int Id { get; set; }
        public int? InvoiceId { get; set; }
        public string SendToPersonId { get; set; }
        public DateTime? SendDate { get; set; }
        public int? MailType { get; set; }
        public string OfflineApproverMailUniqueId { get; set; }
        public string OfflineApproverEmail { get; set; }
        public bool? IsResponseReceived { get; set; }
        public string ResponseText { get; set; }
        public DateTime? ResponseReceivedDate { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
