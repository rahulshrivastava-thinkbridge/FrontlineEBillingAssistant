using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterInvoiceAppealStatus
    {
        public int AppealStatusId { get; set; }
        public string AppealStatusName { get; set; }
        public int DisplayOrder { get; set; }
    }
}
