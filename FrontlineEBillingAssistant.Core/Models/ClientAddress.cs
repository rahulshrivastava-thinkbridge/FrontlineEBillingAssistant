using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ClientAddress
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
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
        public int TypeOfAddressId { get; set; }

        public virtual Client Client { get; set; }
        public virtual TypeOfAddress TypeOfAddress { get; set; }
    }
}
