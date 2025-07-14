using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalProject.Controllers
{
    public class OrderDetailsController : ApiController
    {
        [HttpGet]
        [Route("api/OrdersDetails")]
        public HttpResponseMessage OrdersDetails()
        {
            try
            {
                var data = OrderDetailsService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/OrdersDetails/{id}")]
        public HttpResponseMessage OrdersDetails(int id)
        {
            try
            {
                var data = OrderDetailsService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/OrdersDetails/add")]
        public HttpResponseMessage AddOrderDetails(OrderDetailsDTO OrderDetails)
        {
            try
            {
                var data = OrderDetailsService.Add(OrderDetails);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/OrdersDetails/update")]
        public HttpResponseMessage UpdateOrderDetails(OrderDetailsDTO OrderDetails)
        {
            try
            {
                var data = OrderDetailsService.Update(OrderDetails);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/OrdersDetails/delete")]
        public HttpResponseMessage DeleteOrderDetails(OrderDetailsDTO OrderDetails)
        {
            try
            {
                var data = OrderDetailsService.Delete(OrderDetails.Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
