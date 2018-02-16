using snkrshop.Repositories;
using snkrshop.RepositoriesImplement;
using snkrshop.Services;
using snkrshop.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snkrshop.ServicesImplement
{
    public partial class VoucherServiceImpl : VoucherService
    {
        const string FAIL = "fail";
        const string SUCCESS = "success";
        VoucherRepository voucherRepository;

        public VoucherServiceImpl()
        {
            this.voucherRepository = new VoucherRepositoryImpl();
        }

        public string DeleteVoucher(int voucherId)
        {
            string result = FAIL;
            try
            {
                if (voucherRepository.DeleteVoucher(voucherId))
                {
                    result = SUCCESS;
                }
            }
            catch (Exception ex)
            {
                ex.LogExceptionToFile();
                throw new Exception(ex.Message);


            }
            return result;
        }
    }
}