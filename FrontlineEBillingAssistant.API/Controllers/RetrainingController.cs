using FrontlineEBillingAssistant.Service.Interface.Invoice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using FrontlineEBillingAssistant.Core.Models;
using System.Collections.Generic;

namespace FrontlineEBillingAssistant.API.Controllers
{
    [Authorize]
    [Route("api/retraining")]
    [ApiController]
    public class RetrainingController : ControllerBase
    {
        private readonly IBillyRetrainingService _billyRetrainingService;

        public RetrainingController(IBillyRetrainingService billyRetrainingService)
        {
            _billyRetrainingService = billyRetrainingService;
        }

        /// <summary>
        /// Method Name     : InsertRetrainingData
        /// Developer       : Rahul Shrivastava
        /// Created Date    : 04-02-2022
        /// API Url : /api/retraining/insert
        /// Description : Inserts the retraining data into respective table
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [EnableCors("CORSPolicy")]
        [HttpPost("insert")]
        public string InsertRetrainingData([FromBody] IEnumerable<BillyFeedbackRetrainingTable> model)
        {
            string retVal = string.Empty;
            var result = _billyRetrainingService.InsertRetrainingData(model);

            if (Convert.ToInt32(result) == 0)
            {
                retVal = "Error";
            }
            else if (Convert.ToInt32(result) >= 1)
            {
                retVal = "Success";
            }

            return retVal;
        }

        /// <summary>
        /// Method Name     : GetRetrainingResponse
        /// Developer       : Rahul Shrivastava
        /// Created Date    : 07-02-2022
        /// API Url : /api/retraining/status
        /// Description : Returns the retraining response
        /// </summary>
        /// <param name="strStatus"></param>
        /// <returns></returns>
        [EnableCors("CORSPolicy")]
        [HttpPost("status")]
        public string GetRetrainingResponse(string strStatus)
        {
            string retVal = string.Empty;

            retVal = _billyRetrainingService.GetRetrainingResponse(strStatus);

            return retVal;
        }
    }
}
