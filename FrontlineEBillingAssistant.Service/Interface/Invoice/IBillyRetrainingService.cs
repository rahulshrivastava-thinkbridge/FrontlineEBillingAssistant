using System.Collections.Generic;
using System.Threading.Tasks;
using FrontlineEBillingAssistant.Core.Models;

namespace FrontlineEBillingAssistant.Service.Interface.Invoice
{
    public interface IBillyRetrainingService
    {
        int InsertRetrainingData(IEnumerable<BillyFeedbackRetrainingTable> model);
        string GetRetrainingResponse(string strResponseMessage);
    }
}
