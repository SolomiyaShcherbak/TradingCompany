using System.Collections.Generic;
using TradingCompany.DTO;

namespace DAL.Interfaces
{
    public interface ICategoryDAL
    {
        List<CategoryDTO> GetAllCategories();

        CategoryDTO GetCategoryById(int id);

        CategoryDTO CreateCategory(CategoryDTO category);

        CategoryDTO UpdateCategory(int id, CategoryDTO category);

        CategoryDTO DeleteCategory(int id);
    }
}
