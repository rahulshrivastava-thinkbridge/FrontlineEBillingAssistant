using FrontlineEBillingAssistant.Service.Interface.Invoice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using FrontlineEBillingAssistant.Core.Models;

namespace FrontlineEBillingAssistant.API.Controllers
{
    [Authorize]
    [Route("api/invoice")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;
        private readonly IInvoiceListingGridService _invoiceListingGridService;

        public InvoiceController(IInvoiceService invoiceService, IInvoiceListingGridService invoiceListingGridService)
        {
            _invoiceService = invoiceService;
            _invoiceListingGridService = invoiceListingGridService;
        }

        /// <summary>
        /// Method Name : GetAllInvoices
        /// Developer : Rahul Shrivastava
        /// Created Date : 04-10-2021
        /// Modified Date :
        /// API Url : /api/Invoice/GetAllInvoices
        /// Description : Returns a json object of Invoices
        /// </summary>
        /// <returns></returns>
        [EnableCors("CORSPolicy")]
        [HttpGet("GetAllInvoices")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Object> GetAllInvoices()
        {
            var data = await _invoiceService.GetAllInvoices();
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }

        /// <summary>
        /// Method Name : GetInvoiceById
        /// Developer : Rahul Shrivastava
        /// Created Date : 04-10-2021
        /// Modified Date :
        /// API Url : /api/Invoice/GetInvoiceById?Id={id}
        /// Description : Returns a json object of Invoice based on ID
        /// </summary>
        /// <param name="Id">Invoice ID</param>
        /// <returns></returns>
        [EnableCors("CORSPolicy")]
        [HttpGet("GetInvoiceById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Object> GetInvoiceById([FromQuery] int Id)
        {
            var data = await _invoiceService.GetInvoiceById(Id);
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }

        [EnableCors("CORSPolicy")]
        [HttpGet("listing")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Object> GetInvoiceGridResults()
        {
            var data = await _invoiceListingGridService.GetInvoiceListingGridResults();
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }

        [EnableCors("CORSPolicy")]
        [HttpPost("listing/filtered")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Object> GetFilteredInvoiceGridResults(InvoiceListingFilterRequest invoiceListingFilterRequest)
        {
            if (invoiceListingFilterRequest == null || string.IsNullOrEmpty(invoiceListingFilterRequest.FilterType) || string.IsNullOrEmpty(invoiceListingFilterRequest.FilterValue))
            {
                return BadRequest("Missing filter details");
            }

            var data = await _invoiceListingGridService.GetFilteredInvoiceListingGridResults(invoiceListingFilterRequest.FilterType, invoiceListingFilterRequest.FilterValue);
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }

        [EnableCors("CORSPolicy")]
        [HttpPost("listing/paged")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Object> GetPagedInvoiceGridResults(InvoiceListingPagedRequest invoiceListingPagedRequest)
        {
            if (invoiceListingPagedRequest == null || invoiceListingPagedRequest.PageIndex < 0 || invoiceListingPagedRequest.PageIndex == 0 || invoiceListingPagedRequest.EndRecord == 0)
            {
                return BadRequest("Missing paging details");
            }

            int pageIndex = invoiceListingPagedRequest.PageIndex;
            int pageSize = invoiceListingPagedRequest.EndRecord - invoiceListingPagedRequest.StartRecord;
            string filterText = invoiceListingPagedRequest.FilterText;

            var data = await _invoiceListingGridService.GetInvoiceListingGridResults(pageIndex, pageSize, filterText);
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }
    }
}
