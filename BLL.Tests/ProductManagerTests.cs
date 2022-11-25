using DAL.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using TradingCompany.BLL.Concrete;
using TradingCompany.DTO;

namespace BLL.Tests
{
    [TestFixture]
    public class ProductManagerTests
    {
        private Mock<IProductDAL> productDAL;
        private ProductManager manager;

        [SetUp]
        public void Setup()
        {
            productDAL = new Mock<IProductDAL>(MockBehavior.Strict);
            manager = new ProductManager(productDAL.Object);
        }

        [Test]
        public void AddProductTest()
        {
            var inProduct = new ProductDTO
            {
                Name = "test product",
                CategoryID = 1,
                Description = "test description",
                Price = 100.0000M,
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };
            var outProduct = new ProductDTO { ProductID = 1 };

            productDAL.Setup(d => d.CreateProduct(inProduct)).Returns(outProduct);
            var result = manager.AddProduct(inProduct);

            Assert.IsNotNull(result);
            Assert.AreEqual(outProduct.ProductID, result.ProductID);
        }

        [Test]
        public void GetProductByID_ValidID()
        {
            var outProduct = new ProductDTO { ProductID = 1 };
            productDAL.Setup(p => p.GetProductByID(1)).Returns(outProduct);
            ProductDTO result = manager.GetProductByID(1);
            Assert.AreEqual(outProduct.ProductID, result.ProductID);
        }

        [Test]
        public void GetProductByID_InvalidID()
        {
            var outProduct = (ProductDTO)null;
            productDAL.Setup(p => p.GetProductByID(-1)).Returns(outProduct);
            ProductDTO result = manager.GetProductByID(-1);
            Assert.AreEqual(outProduct, result);
        }

        [Test]
        public void DeleteProduct_ValidID()
        {
            var outProduct = new ProductDTO { ProductID = 1 };
            productDAL.Setup(p => p.DeleteProduct(1)).Returns(outProduct);
            ProductDTO result = manager.DeleteProduct(1);
            Assert.AreEqual(outProduct, result);
        }

        [Test]
        public void DeleteProduct_InvalidID()
        {
            var outProduct = (ProductDTO)null;
            productDAL.Setup(p => p.DeleteProduct(-1)).Returns(outProduct);
            ProductDTO result = manager.DeleteProduct(-1);
            Assert.AreEqual(outProduct, result);
        }
    }
}
