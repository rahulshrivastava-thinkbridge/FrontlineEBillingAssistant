using FrontlineEBillingAssistant.Core.Models;
using FrontlineEBillingAssistant.Repository.Interface.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Repository.Interface
{
    public interface IBillyRetraining : IRepository<BillyFeedbackRetrainingTable>
    {
        public Task<IEnumerable<BillyFeedbackRetrainingTable>> GetAllRetrainingData();
        public Task<IEnumerable<BillyFeedbackRetrainingTable>> GetRetrainingDataByLawFirmId(string lawFirmId);
        public Task<string> InsertRetrainingData(List<BillyFeedbackRetrainingTable> lstObjBillyRetrainingData);
        //public Task<string> GetRetrainingResponse(string strResponseMessage);
    }
}
