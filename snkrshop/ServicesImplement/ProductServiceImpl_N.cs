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
    public partial class ProductServiceImpl : ProductService
    {
        const string FAIL = "fail";
        const string SUCCESS = "success";

        ImageRepository imageRepository;
        ProductSizeRepository productSizeRepository;

        public ProductServiceImpl()
        {
            this.imageRepository = new ImageRepositoryImpl();
            this.productSizeRepository = new ProductSizeRepositoryImpl();
        }

        public string AddProductSize(int productId, int size)
        {
            string result = FAIL;
            try
            {
                if (productSizeRepository.AddProductSize(productId, size))
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

        public string DeleteImage(int imageId)
        {
            string result = FAIL;
            try
            {
                if (imageRepository.DeleteImageOfProduct(imageId))
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