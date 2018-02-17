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
    public partial class DealServiceImpl : DealService
    {
        const string FAIL = "fail";
        const string SUCCESS = "success";
        const int INT_FAIL = -1;

        DealRepository dealRepository;

        public DealServiceImpl()
        {
            this.dealRepository = new DealRepositoryImpl();
        }

        public int AddDeal(string content, DateTime startTime, int duration)
        {
            
            try
            {
                return dealRepository.AddDeal(content, startTime, duration);
            }
            catch (Exception ex)
            {
                ex.LogExceptionToFile();
                throw new Exception(ex.Message);

               
            }
            return INT_FAIL;
        }

        public string DeleteDeal(int dealId)
        {
            string result = FAIL;
            try
            {
                if (dealRepository.DeleteDeal(dealId))
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