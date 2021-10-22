using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterPreparationNote
    {
        public int Id { get; set; }
        public string PreparationNote { get; set; }
        public bool Status { get; set; }
    }
}
