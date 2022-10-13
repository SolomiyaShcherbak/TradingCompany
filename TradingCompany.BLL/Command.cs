using AutoMapper;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DTO;

namespace TradingCompany.BLL
{
    public class Command
    {
        IProductDAL productDAL;
        ICategoryDAL categoryDAL;
        IPostDAL postDAL;
        IMapper Mapper = SetupMapper();

        private static IMapper SetupMapper()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(IProductDAL).Assembly)
                );
            return config.CreateMapper();
        }

        public Command(IProductDAL itemDAL, ICategoryDAL categoryDAL, IPostDAL postDAL)
        {
            this.productDAL = itemDAL;
            this.categoryDAL = categoryDAL;
            this.postDAL = postDAL;
        }

        public void ShowAllProducts()
        {
            var products = productDAL.GetAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }

        public void ShowProductByID(int id)
        {
            var product = productDAL.GetProductByID(id);
            Console.WriteLine(product.ToString());
        }

        public void AddProduct(ProductDTO product)
        {
            product = productDAL.CreateProduct(product);
            if (product == null)
                return;
            Console.WriteLine($"New product ID: {product.ProductID}");
        }

        public void UpdateProduct(int id, ProductDTO product)
        {
            product = productDAL.UpdateProduct(id, product);
            if (product == null)
                return;
            Console.WriteLine($"Updated product ID: {product.ProductID}");
        }

        public void DeleteProduct(int id)
        {
            productDAL.DeleteProduct(id);
        }

        public void ShowAllPosts()
        {
            var posts = postDAL.GetAllPosts();
            foreach (var post in posts)
            {
                Console.WriteLine(post.ToString());
            }
        }

        public void ShowPostByID(int id)
        {
            var post = postDAL.GetPostByID(id);
            Console.WriteLine(post.ToString());
        }

        public void AddPost(PostDTO post)
        {
            post = postDAL.CreatePost(post);
            if (post == null)
                return;
            Console.WriteLine($"New post ID: {post.PostID}");
        }

        public void UpdatePost(int id, PostDTO post)
        {
            post = postDAL.UpdatePost(id, post);
            if (post == null)
                return;
            Console.WriteLine($"Updated post ID: {post.PostID}");
        }

        public void DeletePost(int id)
        {
            postDAL.DeletePost(id);
        }

        public void ShowAllCategories()
        {
            var categories = categoryDAL.GetAllCategories();
            foreach (var category in categories)
            {
                Console.WriteLine(category.ToString());
            }
        }

        public void ShowCategoryByID(int id)
        {
            var category = categoryDAL.GetCategoryById(id);
            if (category == null)
                return;
            Console.WriteLine(category.ToString());
        }

        public void AddCategory(CategoryDTO category)
        {
            category = categoryDAL.CreateCategory(category);
            Console.WriteLine($"New category ID: {category.CategoryID}");
        }

        public void UpdateCategory(int id, CategoryDTO category)
        {
            category = categoryDAL.UpdateCategory(id, category);
            if (category == null)
                return;
            Console.WriteLine($"Updated category ID: {category.CategoryID}");
        }

        public void DeleteCategory(int id)
        {
            categoryDAL.DeleteCategory(id);
        }
    }
}
