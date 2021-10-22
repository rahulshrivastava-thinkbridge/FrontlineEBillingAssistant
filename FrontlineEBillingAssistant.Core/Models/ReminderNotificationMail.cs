using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ReminderNotificationMail
    {
        public int NotifyLogId { get; set; }
        public int? NotifyTypeId { get; set; }
        public int? InvoiceId { get; set; }
        public int? MailToPersonId { get; set; }
        public int MailStatus { get; set; }
        public DateTime? InvoiceAppealDate { get; set; }
        public DateTime InvoiceAppealEndDate { get; set; }
        public int? NotificationPeriod { get; set; }
        public DateTime SendDate { get; set; }
    }
}
