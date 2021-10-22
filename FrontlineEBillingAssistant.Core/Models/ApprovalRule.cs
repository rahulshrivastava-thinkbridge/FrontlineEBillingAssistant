using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ApprovalRule
    {
        public ApprovalRule()
        {
            ClientApprovers = new HashSet<ClientApprover>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ClientId { get; set; }
        public int? LawFirmId { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public int? InvoiceTotalCondition { get; set; }
        public int? ClientCondition { get; set; }
        public decimal? Change { get; set; }
        public int? ChangeCondition { get; set; }
        public short? AllocationPolicy { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int? RuleOrder { get; set; }
        public int Status { get; set; }
        public int? ApproverId { get; set; }
        public int? SecondApproverId { get; set; }
        public bool? IsInternal { get; set; }
        public int? PreparerId { get; set; }
        public int? PreparerCondition { get; set; }
        public int? ThirdApproverId { get; set; }
        public string OfflineApproverEmail { get; set; }
        public bool? IsOffline { get; set; }
        public bool? IsNewWorkFlow { get; set; }

        public virtual User Approver { get; set; }
        public virtual Client Client { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual User Preparer { get; set; }
        public virtual User SecondApprover { get; set; }
        public virtual User ThirdApprover { get; set; }
        public virtual ICollection<ClientApprover> ClientApprovers { get; set; }
    }
}
