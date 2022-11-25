using DAL.Interfaces;
using System.Collections.Generic;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryDAL categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            this.categoryDAL = categoryDAL;
        }

        public List<CategoryDTO> GetAllCategories()
        {
            return categoryDAL.GetAllCategories();
        }

        public CategoryDTO GetCategoryByID(int id)
        {
            return categoryDAL.GetCategoryByID(id);
        }

        public CategoryDTO AddCategory(CategoryDTO category)
        {
            return categoryDAL.CreateCategory(category);
        }

        public CategoryDTO UpdateCategory(int id, CategoryDTO category)
        {
            return categoryDAL.UpdateCategory(id, category);
        }

        public CategoryDTO DeleteCategory(int id)
        {
            return categoryDAL.DeleteCategory(id);
        }
    }
}
