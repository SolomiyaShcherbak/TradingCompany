using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Concrete
{
    public class ProductManager : IProductManager
    {
        private readonly IProductDAL productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            this.productDAL = productDAL;
        }

        public List<ProductDTO> GetAllProducts()
        {
            return productDAL.GetAllProducts();
        }

        public ProductDTO GetProductByID(int id)
        {
            return productDAL.GetProductByID(id);
        }

        public ProductDTO AddProduct(ProductDTO product)
        {
            return productDAL.CreateProduct(product);
        }

        public ProductDTO UpdateProduct(int id, ProductDTO product)
        {
            return productDAL.UpdateProduct(id, product);
        }

        public ProductDTO DeleteProduct(int id)
        {
            return productDAL.DeleteProduct(id);
        }
    }
}
