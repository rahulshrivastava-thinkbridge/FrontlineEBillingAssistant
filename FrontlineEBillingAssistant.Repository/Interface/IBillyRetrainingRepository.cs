using FrontlineEBillingAssistant.Core.Models;
using FrontlineEBillingAssistant.Repository.Interface.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Repository.Interface
{
    public interface IBillyRetrainingRepository : IRepository<BillyFeedbackRetrainingTable>
    {
        //public Task<IEnumerable<BillyFeedbackRetrainingTable>> GetAllRetrainingData();
        //public Task<IEnumerable<BillyFeedbackRetrainingTable>> GetRetrainingDataByLawFirmId(string lawFirmId);
        public int InsertRetrainingData(IEnumerable<BillyFeedbackRetrainingTable> model);
        public string GetRetrainingResponse(string strResponseMessage);
    }
}
