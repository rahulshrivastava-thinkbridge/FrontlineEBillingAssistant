using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class TestLineitemcommunication
    {
        public int Id { get; set; }
        public int InvoiceLineItemId { get; set; }
        public string Comment { get; set; }
        public int WrittenByUserId { get; set; }
        public DateTime WrittenDate { get; set; }
        public int? AddressedToUserId { get; set; }
        public int Status { get; set; }
        public bool? IsCondifdentialBetweenParties { get; set; }
        public bool? IsPrivateToIps { get; set; }
        public int? AddressedToContactId { get; set; }
        public string Cc { get; set; }
        public string EscalatedUniqueId1 { get; set; }
        public string EscalatedUniqueId2 { get; set; }
        public string FollowupUniqueId1 { get; set; }
        public string FollowupUniqueId2 { get; set; }
        public string SendQueryUniqueId { get; set; }
        public bool? IsResponseReceived { get; set; }
        public bool? IsResponseRead { get; set; }
        public string ResponseText { get; set; }
        public string FollowupBy1 { get; set; }
        public string FollowupBy2 { get; set; }
        public DateTime? FollowupDate1 { get; set; }
        public DateTime? FollowupDate2 { get; set; }
        public string EscalatedBy1 { get; set; }
        public string EscalatedBy2 { get; set; }
        public DateTime? EscalatedDate1 { get; set; }
        public DateTime? EscalatedDate2 { get; set; }
        public bool? IsEscalateResponseReceived { get; set; }
        public bool? IsFollowupResponseReceived { get; set; }
        public string EscalateResponseText { get; set; }
        public string FollowupResponseText { get; set; }
    }
}
