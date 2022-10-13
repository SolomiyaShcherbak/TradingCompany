using AutoMapper;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using TradingCompany.DTO;

namespace DAL.Concrete
{
    public class CategoryDAL : ICategoryDAL
    {
        private readonly IMapper _mapper;

        public CategoryDAL(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<CategoryDTO> GetAllCategories()
        {
            using (var entities = new TradingCompanyEntities())
            {
                var categories = entities.Categories.ToList();
                return _mapper.Map<List<CategoryDTO>>(categories);
            }
        }

        public CategoryDTO GetCategoryById(int id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var categoryInDB = entities.Categories.FirstOrDefault(x => x.CategoryID == id);
                return _mapper.Map<CategoryDTO>(categoryInDB);
            }
        }

        public CategoryDTO CreateCategory(CategoryDTO category)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var categoryInDB = _mapper.Map<Category>(category);
                categoryInDB.RowInsertTime = DateTime.UtcNow;
                entities.Categories.Add(categoryInDB);
                entities.SaveChanges();
                return _mapper.Map<CategoryDTO>(categoryInDB);
            }
        }

        public CategoryDTO UpdateCategory(int id, CategoryDTO category)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var categoryToUpdate = entities.Categories.FirstOrDefault(x => x.CategoryID == id);
                categoryToUpdate.Name = category.Name;
                entities.SaveChanges();
                return _mapper.Map<CategoryDTO>(categoryToUpdate);
            }
        }

        public CategoryDTO DeleteCategory(int id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var categoryInDB = entities.Categories.FirstOrDefault(c => c.CategoryID == id);
                entities.Categories.Remove(categoryInDB);
                entities.SaveChanges();
                return _mapper.Map<CategoryDTO>(categoryInDB);
            }
        }
    }
}
