using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ClientDocument
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int DocumentId { get; set; }
        public int? LawFirmId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Document Document { get; set; }
        public virtual LawFirm LawFirm { get; set; }
    }
}
