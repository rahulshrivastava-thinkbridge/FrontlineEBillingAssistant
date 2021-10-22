using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class Zcmatters19apr2019
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LawFirmMatterId { get; set; }
        public string ClientMatterId { get; set; }
        public string AddlReferenceNo { get; set; }
        public int LawFirmId { get; set; }
        public int ClientId { get; set; }
        public int? ProductLineId { get; set; }
        public string ProductLineOtherText { get; set; }
        public string Jurisdiction { get; set; }
        public int Status { get; set; }
        public int? BillingTypeId { get; set; }
        public string Description { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int MasterUtbmsCodeSetId { get; set; }
        public DateTime? DateAssigned { get; set; }
        public DateTime? DateClosed { get; set; }
        public int? LawFirmLocationId { get; set; }
        public string EbillerReference1 { get; set; }
        public string EbillerReference2 { get; set; }
        public string EbillerStatus { get; set; }
        public string EbillerStatusComments { get; set; }
        public DateTime? EbillerStatusCheckDate { get; set; }
        public DateTime? EbillerStatusChangeDate { get; set; }
        public DateTime? DateOfLoss { get; set; }
        public decimal? ClaimAmount { get; set; }
        public DateTime? ClaimEndDate { get; set; }
        public decimal? SettlementAmount { get; set; }
        public bool? IsSplitBill { get; set; }
    }
}
