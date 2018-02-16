using snkrshop.Services;
using snkrshop.ServicesImplement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace snkrshop.Controllers
{
    public class VoucherController : ApiController
    {
        VoucherService voucherService = new VoucherServiceImpl();

        [Route("voucher/delete")]
        public string DeleteVoucher(int voucherId)
        {
            return this.voucherService.DeleteVoucher(voucherId);
        }
    }
}
