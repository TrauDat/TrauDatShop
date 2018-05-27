using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrauDatShop.Service;
using TrauDatShop.Web.Infrastructure.Core;

namespace TrauDatShop.Web.Api
{
    [Authorize]
    [RoutePrefix("api/statistic")]
    public class StatisticController : ApiControllerBase
    {
        IStatisticService _statisticServicce;
        public StatisticController(IErrorService errorService, IStatisticService statisticServicce) : base(errorService)
        {
            _statisticServicce = statisticServicce;
        }
        [Route("getrevenue")]
        [HttpGet]
        public HttpResponseMessage GetRevenueStatistic(HttpRequestMessage request, string fromDate, string toDate)
        {
            return CreateHttpResponse(request, () => 
            {
                var model = _statisticServicce.GetRevenueStatistic(fromDate, toDate);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, model);
                return response;
            });
        }
    }
}
