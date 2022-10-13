using AutoMapper;
using DAL.Concrete;
using System;
using TradingCompany.DTO;

namespace TradingCompany
{
    public class ActionsMenu
    {
        IMapper Mapper = SetupMapper();

        private static IMapper SetupMapper()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(CategoryDAL).Assembly)
                );
            return config.CreateMapper();
        }

        protected void ShowAllNews()
        {
            var DAL = new PostDAL(Mapper);
            var posts = DAL.GetAllPosts();

            foreach (var post in posts)
            {
                Console.WriteLine(post.ToString());
            }
        }

        protected void ShowNewsByID()
        {
            Console.WriteLine("Enter post ID:");
            var id = int.Parse(Console.ReadLine());

            var DAL = new PostDAL(Mapper);
            var post = DAL.GetPostByID(id);

            Console.WriteLine(post.ToString());
        }

        protected void AddNews()
        {
            Console.WriteLine("Enter post title:");
            var title = Console.ReadLine();
            Console.WriteLine("Enter post content:");
            var content = Console.ReadLine();

            var DAL = new PostDAL(Mapper);
            var post = new PostDTO
            {
                Title = title,
                Content = content,
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };
            post = DAL.CreatePost(post);
            Console.WriteLine($"New post ID: {post.PostID}");
        }

        protected void UpdateNews()
        {
            Console.WriteLine("Enter post id:");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter post title:");
            var title = Console.ReadLine();
            Console.WriteLine("Enter post content:");
            var content = Console.ReadLine();

            var DAL = new PostDAL(Mapper);
            var post = new PostDTO
            {
                Title = title,
                Content = content,
                RowUpdateTime = DateTime.UtcNow
            };
            post = DAL.UpdatePost(id, post);
            Console.WriteLine($"Updated post ID: {post.PostID}");
        }

        protected void DeleteNews()
        {
            Console.WriteLine("Enter post ID:");
            var id = int.Parse(Console.ReadLine());
            var DAL = new PostDAL(Mapper);
            DAL.DeletePost(id);
        }

        protected void ShowAllCategories()
        {
            var DAL = new CategoryDAL(Mapper);
            var categories = DAL.GetAllCategories();

            foreach (var category in categories)
            {
                Console.WriteLine(category.ToString());
            }
        }

        protected void ShowCategoryByID()
        {
            Console.WriteLine("Enter category ID:");
            var id = int.Parse(Console.ReadLine());

            var DAL = new CategoryDAL(Mapper);
            var category = DAL.GetCategoryById(id);

            Console.WriteLine(category.ToString());
        }

        protected void AddCategory()
        {
            Console.WriteLine("Enter category name:");
            var name = Console.ReadLine();

            var DAL = new CategoryDAL(Mapper);
            var category = new CategoryDTO
            {
                Name = name
            };
            category = DAL.CreateCategory(category);
            Console.WriteLine($"New category ID: {category.CategoryID}");
        }

        protected void UpdateCategory()
        {
            Console.WriteLine("Enter category id:");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter category name:");
            var name = Console.ReadLine();

            var DAL = new CategoryDAL(Mapper);
            var category = new CategoryDTO
            {
                Name = name,
                RowInsertTime = DateTime.UtcNow
            };
            category = DAL.UpdateCategory(id, category);
            Console.WriteLine($"Updated category ID: {category.CategoryID}");
        }

        protected void DeleteCategory()
        {
            Console.WriteLine("Enter category ID:");
            var id = int.Parse(Console.ReadLine());
            var DAL = new CategoryDAL(Mapper);
            DAL.DeleteCategory(id);
        }

        protected void ShowAllProducts()
        {
            var DAL = new ProductDAL(Mapper);
            var products = DAL.GetAllProducts();

            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }

        protected void ShowProductByID()
        {
            Console.WriteLine("Enter product ID:");
            var id = int.Parse(Console.ReadLine());

            var DAL = new ProductDAL(Mapper);
            var product = DAL.GetProductByID(id);

            Console.WriteLine(product.ToString());
        }

        protected void AddProduct()
        {
            Console.WriteLine("Enter product name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter product category ID:");
            var categoryID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product description:");
            var description = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            var price = decimal.Parse(Console.ReadLine());

            var DAL = new ProductDAL(Mapper);
            var product = new ProductDTO
            {
                Name = name,
                CategoryID = categoryID,
                Description = description,
                Price = price,
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };
            product = DAL.CreateProduct(product);
            Console.WriteLine($"New product ID: {product.ProductID}");
        }

        protected void UpdateProduct()
        {
            Console.WriteLine("Enter product id:");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter product category ID:");
            var categoryID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product description:");
            var description = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            var price = decimal.Parse(Console.ReadLine());

            var DAL = new ProductDAL(Mapper);
            var product = new ProductDTO
            {
                Name = name,
                CategoryID = categoryID,
                Description = description,
                Price = price,
                RowUpdateTime = DateTime.UtcNow
            };
            product = DAL.UpdateProduct(id, product);
            Console.WriteLine($"Updated product ID: {product.ProductID}");
        }

        protected void DeleteProduct()
        {
            Console.WriteLine("Enter product ID:");
            var id = int.Parse(Console.ReadLine());
            var DAL = new ProductDAL(Mapper);
            DAL.DeleteProduct(id);
        }
    }
}
