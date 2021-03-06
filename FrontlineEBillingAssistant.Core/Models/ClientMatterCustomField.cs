using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class ClientMatterCustomField
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int MatterCustomFieldId { get; set; }
        public int ProductLineId { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedTime { get; set; }

        public virtual Client Client { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual MatterCustomField MatterCustomField { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual MasterProductLine ProductLine { get; set; }
    }
}
