using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Interfaces
{
    public interface IProductManager
    {
        List<ProductDTO> GetAllProducts();

        ProductDTO GetProductByID(int id);

        ProductDTO AddProduct(ProductDTO product);

        ProductDTO UpdateProduct(int id, ProductDTO product);

        ProductDTO DeleteProduct(int id);
    }
}
