using AutoMapper;
using DAL.Concrete;
using NUnit.Framework;
using System;
using TradingCompany.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Data.Entity.Validation;

namespace DAL.Tests
{
    [TestFixture]
    public class CategoryDALTests
    {
        private IMapper _mapper;

        [OneTimeSetUp]
        public void SetupMapper()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(CategoryDAL).Assembly)
                );
            _mapper = config.CreateMapper();
        }

        [Test, Rollback]
        public void Test_GetAllCategories_ValidOutput()
        {
            InsertCategoryIntoDatabase();
            var categoryDAL = new CategoryDAL(_mapper);

            var categories = categoryDAL.GetAllCategories();

            Assert.AreEqual(1, categories.Count);
        }

        [Test, Rollback]
        public void Test_GetAllCategories_EmptyList()
        {
            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Category]");
            }
            var categoryDAL = new CategoryDAL(_mapper);

            var categories = categoryDAL.GetAllCategories();

            Assert.IsTrue(categories.Count == 0);
        }

        [Test, Rollback]
        public void Test_GetCategoryByID_ValidID()
        {
            var category = InsertCategoryIntoDatabase();
            var categoryDAL = new CategoryDAL(_mapper);

            var result = categoryDAL.GetCategoryById(category.CategoryID);

            var isoConvert = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            var expectedString = JsonConvert.SerializeObject(category, isoConvert);
            var actualString = JsonConvert.SerializeObject(result, isoConvert);

            Assert.AreEqual(expectedString, actualString);
        }

        [Test, Rollback]
        public void Test_GetCategoryByID_InvalidID()
        {
            var categoryDAL = new CategoryDAL(_mapper);
            var result = categoryDAL.GetCategoryById(-1);

            Assert.IsNull(result);
        }

        [Test, Rollback]
        public void Test_CreateCategory_ValidData()
        {
            var category = InsertCategoryIntoDatabase();

            Assert.IsTrue(category.CategoryID > 0);
        }

        [Test, Rollback]
        public void Test_CreateCategory_InvalidData()
        {
            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Category]");
            }

            var categoryDAL = new CategoryDAL(_mapper);
            var category = new CategoryDTO
            {
                Name = "But Jesus said to him, [My] friend, for what purpose art thou come? Then coming up they laid hands upon Jesus and seized him.",
            };

            Assert.Throws<DbEntityValidationException>(() => categoryDAL.CreateCategory(category));
        }

        [Test, Rollback]
        public void Test_UpdateCategory_ValidData()
        {
            var categoryDAL = new CategoryDAL(_mapper);
            var category = InsertCategoryIntoDatabase();

            var updatedCategory = new CategoryDTO
            {
                Name = "test category updated",
            };

            var result = categoryDAL.UpdateCategory(category.CategoryID, updatedCategory);

            Assert.AreEqual(category.CategoryID, result.CategoryID);
            Assert.AreEqual(updatedCategory.Name, result.Name);
        }

        [Test, Rollback]
        public void Test_UpdateCategory_InvalidData()
        {
            var categoryDAL = new CategoryDAL(_mapper);
            var category = InsertCategoryIntoDatabase();

            var updatedCategory = new CategoryDTO
            {
                Name = "In the same way, after the supper he took the cup, saying, “This cup is the new covenant in my blood, which is poured out for you...”",
            };

            Assert.Throws<DbEntityValidationException>(() => categoryDAL.UpdateCategory(category.CategoryID, updatedCategory));
        }

        [Test, Rollback]
        public void Test_DeleteCategory_ValidID()
        {
            var categoryDAL = new CategoryDAL(_mapper);
            var category = InsertCategoryIntoDatabase();

            var result = categoryDAL.DeleteCategory(category.CategoryID);

            var isoConvert = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            var expectedString = JsonConvert.SerializeObject(category, isoConvert);
            var actualString = JsonConvert.SerializeObject(result, isoConvert);

            Assert.AreEqual(expectedString, actualString);
            Assert.AreEqual(0, categoryDAL.GetAllCategories().Count);
        }

        [Test, Rollback]
        public void Test_DeleteCategory_InvalidID()
        {
            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Category]");
            }

            var categoryDAL = new CategoryDAL(_mapper);

            Assert.Throws<ArgumentNullException>(() => categoryDAL.DeleteCategory(1));
        }

        private CategoryDTO InsertCategoryIntoDatabase()
        {
            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Category]");
            }

            var categoryDAL = new CategoryDAL(_mapper);
            var category = new CategoryDTO
            {
                Name = "test category",
            };

            return categoryDAL.CreateCategory(category);
        }
    }
}
