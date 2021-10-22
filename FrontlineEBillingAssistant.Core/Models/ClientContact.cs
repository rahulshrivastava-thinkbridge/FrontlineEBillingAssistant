using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ClientContact
    {
        public ClientContact()
        {
            MatterClientContacts = new HashSet<MatterClientContact>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Cell { get; set; }
        public int LawfirmClientId { get; set; }

        public virtual LawfirmClient LawfirmClient { get; set; }
        public virtual ICollection<MatterClientContact> MatterClientContacts { get; set; }
    }
}
