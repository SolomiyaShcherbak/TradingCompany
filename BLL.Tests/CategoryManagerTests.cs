using NUnit.Framework;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using TradingCompany.BLL.Concrete;
using DAL.Concrete;
using TradingCompany.DTO;

namespace BLL.Tests
{
    [TestFixture]
    public class CategoryManagerTests
    {
        private Mock<ICategoryDAL> categoryDAL;
        private CategoryManager manager;

        [SetUp]
        public void Setup()
        {
            categoryDAL = new Mock<ICategoryDAL>(MockBehavior.Strict);
            manager = new CategoryManager(categoryDAL.Object);
        }

        [Test]
        public void AddCategoryTest()
        {
            var inCategory = new CategoryDTO
            {
                Name = "test category",
            };
            var outCategory = new CategoryDTO { CategoryID = 1 };

            categoryDAL.Setup(d => d.CreateCategory(inCategory)).Returns(outCategory);
            var result = manager.AddCategory(inCategory);

            Assert.IsNotNull(result);
            Assert.AreEqual(outCategory.CategoryID, result.CategoryID);
        }

        [Test]
        public void GetCategoryByID_ValidID()
        {
            var outCategory = new CategoryDTO { CategoryID = 1 };
            categoryDAL.Setup(c => c.GetCategoryByID(1)).Returns(outCategory);
            CategoryDTO result = manager.GetCategoryByID(1);
            Assert.AreEqual(outCategory.CategoryID, result.CategoryID);
        }

        [Test]
        public void GetCategoryByID_InvalidID()
        {
            var outCategory = (CategoryDTO)null;
            categoryDAL.Setup(c => c.GetCategoryByID(-1)).Returns(outCategory);
            CategoryDTO result = manager.GetCategoryByID(-1);
            Assert.AreEqual(outCategory, result);
        }

        [Test]
        public void DeleteCategory_ValidID()
        {
            var outCategory = new CategoryDTO { CategoryID = 1 };
            categoryDAL.Setup(c => c.DeleteCategory(1)).Returns(outCategory);
            CategoryDTO result = manager.DeleteCategory(1);
            Assert.AreEqual(outCategory, result);
        }

        [Test]
        public void DeleteCategory_InvalidID()
        {
            var outCategory = (CategoryDTO)null;
            categoryDAL.Setup(c => c.DeleteCategory(-1)).Returns(outCategory);
            CategoryDTO result = manager.DeleteCategory(-1);
            Assert.AreEqual(outCategory, result);
        }
    }
}
