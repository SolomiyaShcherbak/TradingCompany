using AutoMapper;
using DAL.Concrete;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using TradingCompany.DTO;
using System.Data.Entity.Infrastructure;

namespace DAL.Tests
{
    [TestFixture]
    public class ProductDALTests
    {
        private IMapper _mapper;

        [OneTimeSetUp]
        public void SetupMapper()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(ProductDAL).Assembly)
                );
            _mapper = config.CreateMapper();
        }

        [Test, Rollback]
        public void Test_GetAllProducts_ValidOutput()
        {
            InsertProductIntoDatabase();
            var productDAL = new ProductDAL(_mapper);

            var products = productDAL.GetAllProducts();

            Assert.AreEqual(1, products.Count);
        }

        [Test, Rollback]
        public void Test_GetAllProducts_EmptyList()
        {
            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Product]");
            }
            var productDAL = new ProductDAL(_mapper);

            var products = productDAL.GetAllProducts();

            Assert.IsTrue(products.Count == 0);
        }

        [Test, Rollback]
        public void Test_GetProductByID_ValidID()
        {
            var product = InsertProductIntoDatabase();
            var productDAL = new ProductDAL(_mapper);

            var result = productDAL.GetProductByID(product.ProductID);

            var isoConvert = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            var expectedString = JsonConvert.SerializeObject(product, isoConvert);
            var actualString = JsonConvert.SerializeObject(result, isoConvert);

            Assert.AreEqual(expectedString, actualString);
        }

        [Test, Rollback]
        public void Test_GetProductByID_InvalidID()
        {
            var productDAL = new ProductDAL(_mapper);
            var result = productDAL.GetProductByID(-1);

            Assert.IsNull(result);
        }

        [Test, Rollback]
        public void Test_CreateProduct_ValidData()
        {
            var product = InsertProductIntoDatabase();

            Assert.IsTrue(product.ProductID > 0);
        }

        [Test, Rollback]
        public void Test_CreateProduct_InvalidData()
        {
            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Product]");
            }

            var productDAL = new ProductDAL(_mapper);
            var product = new ProductDTO
            {
                Name = "test product",
                CategoryID = -1,
                Description = "test description",
                Price = -100.0000M,
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };

            Assert.IsNull(productDAL.CreateProduct(product));
        }

        [Test, Rollback]
        public void Test_UpdateProduct_ValidData()
        {
            var productDAL = new ProductDAL(_mapper);
            var product = InsertProductIntoDatabase();

            var updatedProduct = new ProductDTO
            {
                Name = "test product updated",
                CategoryID = product.CategoryID,
                Description = "test description updated",
                Price = 50.0000M,
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };

            var result = productDAL.UpdateProduct(product.ProductID, updatedProduct);

            Assert.AreEqual(product.ProductID, result.ProductID);
            Assert.AreEqual(updatedProduct.Name, result.Name);
            Assert.AreEqual(updatedProduct.CategoryID, result.CategoryID);
            Assert.AreEqual(updatedProduct.Description, result.Description);
            Assert.AreEqual(updatedProduct.Price, result.Price);
        }

        [Test, Rollback]
        public void Test_UpdateProduct_InvalidData()
        {
            var productDAL = new ProductDAL(_mapper);
            var product = InsertProductIntoDatabase();

            var updatedProduct = new ProductDTO
            {
                Name = "test product updated",
                CategoryID = -1,
                Description = "test description updated",
                Price = -100.0000M,
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };

            Assert.IsNull(productDAL.UpdateProduct(product.ProductID, updatedProduct));
        }

        [Test, Rollback]
        public void Test_DeleteProduct_ValidID()
        {
            var productDAL = new ProductDAL(_mapper);
            var product = InsertProductIntoDatabase();

            var result = productDAL.DeleteProduct(product.ProductID);

            var isoConvert = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            var expectedString = JsonConvert.SerializeObject(product, isoConvert);
            var actualString = JsonConvert.SerializeObject(result, isoConvert);

            Assert.AreEqual(expectedString, actualString);
            Assert.AreEqual(0, productDAL.GetAllProducts().Count);
        }

        [Test, Rollback]
        public void Test_DeleteProduct_InvalidID()
        {
            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Product]");
            }

            var productDAL = new ProductDAL(_mapper);

            Assert.IsNull(productDAL.DeleteProduct(1));
        }

        private ProductDTO InsertProductIntoDatabase()
        {
            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Product]");
            }

            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Category]");
            }

            var categoryDAL = new CategoryDAL(_mapper);
            var category = new CategoryDTO
            {
                Name = "test category",
            };

            category = categoryDAL.CreateCategory(category);

            var productDAL = new ProductDAL(_mapper);
            var product = new ProductDTO
            {
                Name = "test product",
                CategoryID = category.CategoryID,
                Description = "test description",
                Price = 100.0000M,
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };

            return productDAL.CreateProduct(product);
        }
    }
}
