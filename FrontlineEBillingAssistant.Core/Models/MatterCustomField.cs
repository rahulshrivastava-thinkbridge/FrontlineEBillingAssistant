using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MatterCustomField
    {
        public MatterCustomField()
        {
            ClientMatterCustomFields = new HashSet<ClientMatterCustomField>();
            LawFirmMatterCustomFields = new HashSet<LawFirmMatterCustomField>();
            MatterCustomFieldValues = new HashSet<MatterCustomFieldValue>();
        }

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Key { get; set; }
        public int TypeOfField { get; set; }
        public string ValidationExpression { get; set; }
        public string ValidationMessage { get; set; }
        public bool IsMandatory { get; set; }
        public string DefaultValue { get; set; }
        public string Options { get; set; }
        public string HelpText { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedTime { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual ICollection<ClientMatterCustomField> ClientMatterCustomFields { get; set; }
        public virtual ICollection<LawFirmMatterCustomField> LawFirmMatterCustomFields { get; set; }
        public virtual ICollection<MatterCustomFieldValue> MatterCustomFieldValues { get; set; }
    }
}
