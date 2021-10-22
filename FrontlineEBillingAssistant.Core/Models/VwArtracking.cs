using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class VwArtracking
    {
        public int LawFirmId { get; set; }
        public string ClientName { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal? PaymentReceived { get; set; }
        public decimal? TotalWriteOff { get; set; }
        public decimal? Ar { get; set; }
        public int? WeekOfMonth { get; set; }
        public int? MonthNumber { get; set; }
        public int? YearNumber { get; set; }
        public string MonthName { get; set; }
        public int? DateValue { get; set; }
        public string FirmMatterId { get; set; }
        public string InvoiceType { get; set; }
    }
}
