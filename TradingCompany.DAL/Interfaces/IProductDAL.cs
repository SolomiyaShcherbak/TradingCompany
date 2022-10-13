using System.Collections.Generic;
using TradingCompany.DTO;

namespace DAL.Interfaces
{
    public interface IProductDAL
    {
        List<ProductDTO> GetAllProducts();

        ProductDTO CreateProduct(ProductDTO product);

        ProductDTO GetProductByID(int id);

        ProductDTO UpdateProduct(int id, ProductDTO product);

        ProductDTO DeleteProduct(int id);
    }
}
