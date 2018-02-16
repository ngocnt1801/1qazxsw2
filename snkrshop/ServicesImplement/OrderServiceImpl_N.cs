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
    public partial class OrderServiceImpl : OrderService
    {
        const string FAIL = "fail";
        const string SUCCESS = "success";
        OrderRepository orderRepository;

        public OrderServiceImpl()
        {
            this.orderRepository = new OrderRepositoryImpl();
        }

        public string CancelOrder(int orderId)
        {
            string result = FAIL;
            try
            {
                if (orderRepository.CancelOrder(orderId))
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

        public string DeleteOrder(int orderId)
        {
            string result = FAIL;
            try
            {
                if (orderRepository.DeleteOrder(orderId))
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