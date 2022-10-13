using AutoMapper;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using TradingCompany.DTO;

namespace DAL.Concrete
{
    public class ProductDAL : IProductDAL
    {
        private readonly IMapper _mapper;

        public ProductDAL(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<ProductDTO> GetAllProducts()
        {
            using (var entities = new TradingCompanyEntities())
            {
                var products = entities.Products.ToList();
                return _mapper.Map<List<ProductDTO>>(products);
            }
        }

        public ProductDTO GetProductByID(int id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var productInDB = entities.Products.FirstOrDefault(x => x.ProductID == id);
                return _mapper.Map<ProductDTO>(productInDB);
            }
        }

        public ProductDTO CreateProduct(ProductDTO product)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var productInDB = _mapper.Map<Product>(product);
                entities.Products.Add(productInDB);
                entities.SaveChanges();
                return _mapper.Map<ProductDTO>(productInDB);
            }
        }

        public ProductDTO UpdateProduct(int id, ProductDTO product)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var productToUpdate = entities.Products.FirstOrDefault(x => x.ProductID == id);
                productToUpdate.Name = product.Name;
                productToUpdate.CategoryID = product.CategoryID;
                productToUpdate.Description = product.Description;
                productToUpdate.Price = product.Price;
                productToUpdate.RowUpdateTime = DateTime.UtcNow;
                entities.SaveChanges();
                return _mapper.Map<ProductDTO>(productToUpdate);
            }
        }

        public ProductDTO DeleteProduct(int id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var productInDB = entities.Products.FirstOrDefault(p => p.ProductID == id);
                entities.Products.Remove(productInDB);
                entities.SaveChanges();
                return _mapper.Map<ProductDTO>(productInDB);
            }
        }
    }
}
