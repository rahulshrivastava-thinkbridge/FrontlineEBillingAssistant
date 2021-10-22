using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ClientApprover
    {
        public int Id { get; set; }
        public int? ApprovalRuleId { get; set; }
        public int? ApproverId { get; set; }
        public int? ApprovalOrder { get; set; }

        public virtual ApprovalRule ApprovalRule { get; set; }
        public virtual User Approver { get; set; }
    }
}
