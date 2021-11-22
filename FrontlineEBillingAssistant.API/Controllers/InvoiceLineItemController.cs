using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using FrontlineEBillingAssistant.Service.Interface.Invoice;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using FrontlineEBillingAssistant.Core.Models;

namespace FrontlineEBillingAssistant.API.Controllers
{
    [Authorize]
    [Route("api/invoicelineitems")]
    [ApiController]
    public class InvoiceLineItemController : ControllerBase
    {
        private readonly IInvoiceLineItemService _invoiceLineItemService;

        public InvoiceLineItemController(IInvoiceLineItemService invoiceLineItemService)
        {
            _invoiceLineItemService = invoiceLineItemService;
        }

        /// <summary>
        /// Method Name : GetAllInvoiceLineItems
        /// Developer : Rahul Shrivastava
        /// Created Date : 04-10-2021
        /// Modified Date :
        /// API Url : /api/InvoiceLineItem/GetAllInvoiceLineItems
        /// Description : Returns a json object of InvoiceLineItems
        /// </summary>
        /// <returns></returns>
        [EnableCors("CORSPolicy")]
        [HttpGet("GetAllInvoiceLineItems")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Object> GetAllInvoiceLineItems()
        {
            var data = await _invoiceLineItemService.GetAllInvoiceLineItems();
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }

        /// <summary>
        /// Method Name : GetInvoiceLineItemsById
        /// Developer : Rahul Shrivastava
        /// Created Date : 04-10-2021
        /// Modified Date :
        /// API Url : /api/InvoiceLineItem/GetInvoiceLineItemsById?Id={id}
        /// Description : Returns a json object of InvoiceLineItems based on Invoice Client ID
        /// </summary>
        /// <param name="Id">Invoice Client ID</param>
        /// <returns></returns>
        [EnableCors("CORSPolicy")]
        [HttpGet("listing")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Object> GetInvoiceLineItemsById([FromQuery] int Id)
        {
            var data = await _invoiceLineItemService.GetInvoiceLineItemsById(Id);
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );

            return json;
        }

        [EnableCors("CORSPolicy")]
        [HttpPost("update")]
        public string UpdateInvoiceLineItems([FromBody] InvoiceLineItemsListingGridModel model)
        {
            string retVal = string.Empty;
            var result = _invoiceLineItemService.UpdateInvoiceLineItems(model);

            if (Convert.ToInt32(result) == 0)
            {
                retVal = "Fail";
            }
            else if (Convert.ToInt32(result) >= 1)
            {
                retVal = "Success";
            }

            return retVal;
        }
    }
}
