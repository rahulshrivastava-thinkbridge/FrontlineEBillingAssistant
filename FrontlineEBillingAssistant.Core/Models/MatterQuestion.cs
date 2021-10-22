using System;
using System.Collections.Generic;

#nullable disable

namespace FrontlineEBillingAssistant.Core.Models
{
    public partial class MatterQuestion
    {
        public int Id { get; set; }
        public int MatterId { get; set; }
        public int QuestionId { get; set; }
    }
}
