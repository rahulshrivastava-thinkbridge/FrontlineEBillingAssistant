using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MasterTemplateActionType
    {
        public MasterTemplateActionType()
        {
            CustomEmailTemplates = new HashSet<CustomEmailTemplate>();
            EmailTemplates = new HashSet<EmailTemplate>();
        }

        public int Id { get; set; }
        public string ActionName { get; set; }

        public virtual ICollection<CustomEmailTemplate> CustomEmailTemplates { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplates { get; set; }
    }
}
