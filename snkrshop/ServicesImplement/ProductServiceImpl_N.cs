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

        public ProductServiceImpl()
        {
            this.imageRepository = new ImageRepositoryImpl();
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