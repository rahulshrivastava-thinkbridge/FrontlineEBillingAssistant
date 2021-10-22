using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class TypeOfAddress
    {
        public TypeOfAddress()
        {
            ClientAddresses = new HashSet<ClientAddress>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<ClientAddress> ClientAddresses { get; set; }
    }
}
