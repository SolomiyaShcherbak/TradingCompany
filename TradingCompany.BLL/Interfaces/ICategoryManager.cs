using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Interfaces
{
    public interface ICategoryManager
    {
        List<CategoryDTO> GetAllCategories();

        CategoryDTO GetCategoryByID(int id);

        CategoryDTO AddCategory(CategoryDTO category);

        CategoryDTO UpdateCategory(int id, CategoryDTO category);

        CategoryDTO DeleteCategory(int id);
    }
}
