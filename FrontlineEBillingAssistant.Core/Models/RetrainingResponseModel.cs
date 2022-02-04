using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Core.Models
{
    public class RetrainingResponseModel
    {
        public int RetrainingRequestId { get; set; }
        public List<BillyFeedbackRetrainingTable> lstBillyRetrainingData { get; set; }
    }
}
