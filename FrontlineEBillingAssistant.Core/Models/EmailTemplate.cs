using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class EmailTemplate
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int TemplateActionTypeId { get; set; }

        public virtual MasterTemplateActionType TemplateActionType { get; set; }
    }
}
