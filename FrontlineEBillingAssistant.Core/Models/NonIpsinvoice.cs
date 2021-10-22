using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class NonIpsinvoice
    {
        public int Id { get; set; }
        public int LawFirmId { get; set; }
        public string ClientName { get; set; }
        public string InvoiceNumber { get; set; }
        public string FirmMatterId { get; set; }
        public string ClientMatterId { get; set; }
        public string MatterName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int? InvoiceStatusId { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal? PaymentReceived1Amount { get; set; }
        public decimal? PaymentReceived2Amount { get; set; }
        public decimal? PaymentReceived3Amount { get; set; }
        public DateTime? PaymentReceived1Date { get; set; }
        public DateTime? PaymentReceived2Date { get; set; }
        public DateTime? PaymentReceived3Date { get; set; }
        public decimal? TotalPaymentReceived { get; set; }
        public decimal? WriteOff1 { get; set; }
        public decimal? WriteOff2 { get; set; }
        public DateTime? WriteOff1Date { get; set; }
        public DateTime? WriteOff2Date { get; set; }
        public decimal? TotalWriteOff { get; set; }
    }
}
