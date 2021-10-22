using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class FavouriteReport
    {
        public int Id { get; set; }
        public int MasterReportId { get; set; }
        public int UserId { get; set; }

        public virtual MasterReport MasterReport { get; set; }
    }
}
