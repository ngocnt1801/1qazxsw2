using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public partial class DealController : ApiController
    {
        [Route("deal/update")]
        public string UpdateDeal(int id, string content, DateTime startTime, int duration)
        {
            return this.dealService.UpdateDeal( id, content, startTime, duration);
        }
        [Route("deal/deleteproduct")]
        public string DeleteProductFromDeal(int proId, int dealId)
        {
            return this.dealService.DeleteProductFromDeal( proId, dealId);
        }
    }
}