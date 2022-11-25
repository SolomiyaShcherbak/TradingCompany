using AutoMapper;
using DAL.Concrete;
using System;
using TradingCompany.BLL;
using TradingCompany.DTO;

namespace TradingCompany
{
    public class ActionMenu
    {
        Command command;
        IMapper Mapper = SetupMapper();

        private static IMapper SetupMapper()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(CategoryDAL).Assembly)
                );
            return config.CreateMapper();
        }

        public ActionMenu()
        {
            command = new Command(new ProductDAL(Mapper), new CategoryDAL(Mapper), new PostDAL(Mapper));
        }

        public void ShowAllPosts()
        {
            var posts = command.GetAllPosts();
            foreach (var post in posts)
            {
                Console.WriteLine(post.ToString());
            }
        }

        public void ShowPostByID()
        {
            Console.WriteLine("Enter post ID:");
            var id = int.Parse(Console.ReadLine());
            var post = command.GetPostByID(id);
            Console.WriteLine(post.ToString());
        }

        public void AddPost()
        {
            Console.WriteLine("Enter post title:");
            var title = Console.ReadLine();
            Console.WriteLine("Enter post content:");
            var content = Console.ReadLine();

            var post = new PostDTO
            {
                Title = title,
                Content = content,
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };
            post = command.AddPost(post);
            if (post == null)
                return;
            Console.WriteLine($"New post ID: {post.PostID}");
        }

        public void UpdatePost()
        {
            Console.WriteLine("Enter post id:");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter post title:");
            var title = Console.ReadLine();
            Console.WriteLine("Enter post content:");
            var content = Console.ReadLine();

            var post = new PostDTO
            {
                Title = title,
                Content = content,
                RowUpdateTime = DateTime.UtcNow
            };
            post = command.UpdatePost(id, post);
            if (post == null)
                return;
            Console.WriteLine($"Updated post ID: {post.PostID}");
        }

        public void DeletePost()
        {
            Console.WriteLine("Enter post ID:");
            var id = int.Parse(Console.ReadLine());
            command.DeletePost(id);
        }

        public void ShowAllCategories()
        {
            var categories = command.GetAllCategories();
            foreach (var category in categories)
            {
                Console.WriteLine(category.ToString());
            }
        }

        public void ShowCategoryByID()
        {
            Console.WriteLine("Enter category ID:");
            var id = int.Parse(Console.ReadLine());
            var category = command.GetCategoryByID(id);
            Console.WriteLine(category.ToString());
        }

        public void AddCategory()
        {
            Console.WriteLine("Enter category name:");
            var name = Console.ReadLine();

            var category = new CategoryDTO
            {
                Name = name
            };
            category = command.AddCategory(category);
            if (category == null)
                return;
            Console.WriteLine($"New category ID: {category.CategoryID}");
        }

        public void UpdateCategory()
        {
            Console.WriteLine("Enter category id:");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter category name:");
            var name = Console.ReadLine();

            var category = new CategoryDTO
            {
                Name = name,
                RowInsertTime = DateTime.UtcNow
            };
            category = command.UpdateCategory(id, category);
            if (category == null)
                return;
            Console.WriteLine($"Updated category ID: {category.CategoryID}");
        }

        public void DeleteCategory()
        {
            Console.WriteLine("Enter category ID:");
            var id = int.Parse(Console.ReadLine());
            command.DeleteCategory(id);
        }

        public void ShowAllProducts()
        {
            var products = command.GetAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }

        public void ShowProductByID()
        {
            Console.WriteLine("Enter product ID:");
            var id = int.Parse(Console.ReadLine());
            var product = command.GetProductByID(id);
            Console.WriteLine(product.ToString());
        }

        public void AddProduct()
        {
            Console.WriteLine("Enter product name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter product category ID:");
            var categoryID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product description:");
            var description = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            var price = decimal.Parse(Console.ReadLine());

            var product = new ProductDTO
            {
                Name = name,
                CategoryID = categoryID,
                Description = description,
                Price = price,
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };
            product = command.AddProduct(product);
            if (product == null)
                return;
            Console.WriteLine($"New product ID: {product.ProductID}");
        }

        public void UpdateProduct()
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

            var product = new ProductDTO
            {
                Name = name,
                CategoryID = categoryID,
                Description = description,
                Price = price,
                RowUpdateTime = DateTime.UtcNow
            };
            product = command.UpdateProduct(id, product);
            if (product == null)
                return;
            Console.WriteLine($"Updated product ID: {product.ProductID}");
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Enter product ID:");
            var id = int.Parse(Console.ReadLine());
            command.DeleteProduct(id);
        }
    }
}
