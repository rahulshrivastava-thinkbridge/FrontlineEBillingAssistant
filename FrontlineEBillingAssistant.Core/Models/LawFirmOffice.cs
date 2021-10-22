using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class LawFirmOffice
    {
        public LawFirmOffice()
        {
            Matters = new HashSet<Matter>();
        }

        public int Id { get; set; }
        public int LawFirmId { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public int CreatedById { get; set; }
        public int ModifiedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string TaxId { get; set; }
        public string RemitAddr1 { get; set; }
        public string RemitAddr2 { get; set; }
        public string RemitAddr3 { get; set; }
        public string RemitCity { get; set; }
        public string RemitPinCode { get; set; }
        public string RemitState { get; set; }
        public string RemitCountry { get; set; }
        public decimal InvoicePrepRate { get; set; }
        public decimal? TaxRate { get; set; }
        public string LocationTitle { get; set; }
        public decimal? InvoicePrepExpRate { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual LawFirm LawFirm { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual ICollection<Matter> Matters { get; set; }
    }
}
