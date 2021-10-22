using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterSuitCounty
    {
        public int Id { get; set; }
        public int? StateId { get; set; }
        public string CountyName { get; set; }
    }
}
