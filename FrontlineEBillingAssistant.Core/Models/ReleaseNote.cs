using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ReleaseNote
    {
        public int Id { get; set; }
        public string VersionName { get; set; }
        public string FilePath { get; set; }
    }
}
