using System.Collections.Generic;
using System.Threading.Tasks;
using FrontlineEBillingAssistant.Repository.Interface;
using FrontlineEBillingAssistant.Service.Interface.Invoice;
using FrontlineEBillingAssistant.Core.Models;

namespace FrontlineEBillingAssistant.Service.Services.Invoice
{
    public class BillyRetrainingService : IBillyRetrainingService
    {
        private readonly IBillyRetrainingRepository _billyRetrainingRepository;

        public BillyRetrainingService(IBillyRetrainingRepository billyRetrainingRepository)
        {
            _billyRetrainingRepository = billyRetrainingRepository;
        }

        public int InsertRetrainingData(IEnumerable<BillyFeedbackRetrainingTable> model)
        {
            return _billyRetrainingRepository.InsertRetrainingData(model);
        }
    }
}
