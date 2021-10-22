using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class PayerDocument
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int DocumentId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Document Document { get; set; }
    }
}
