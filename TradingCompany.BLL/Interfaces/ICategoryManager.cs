using System.Collections.Generic;
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
