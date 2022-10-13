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
            command.ShowAllPosts();
        }

        public void ShowPostByID()
        {
            Console.WriteLine("Enter post ID:");
            var id = int.Parse(Console.ReadLine());
            command.ShowPostByID(id);
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
            command.AddPost(post);
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
            command.UpdatePost(id, post);
        }

        public void DeletePost()
        {
            Console.WriteLine("Enter post ID:");
            var id = int.Parse(Console.ReadLine());
            command.DeletePost(id);
        }

        public void ShowAllCategories()
        {
            command.ShowAllCategories();
        }

        public void ShowCategoryByID()
        {
            Console.WriteLine("Enter category ID:");
            var id = int.Parse(Console.ReadLine());
            command.ShowCategoryByID(id);
        }

        public void AddCategory()
        {
            Console.WriteLine("Enter category name:");
            var name = Console.ReadLine();

            var category = new CategoryDTO
            {
                Name = name
            };
            command.AddCategory(category);
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
            command.UpdateCategory(id, category);
        }

        public void DeleteCategory()
        {
            Console.WriteLine("Enter category ID:");
            var id = int.Parse(Console.ReadLine());
            command.DeleteCategory(id);
        }

        public void ShowAllProducts()
        {
            command.ShowAllProducts();
        }

        public void ShowProductByID()
        {
            Console.WriteLine("Enter product ID:");
            var id = int.Parse(Console.ReadLine());
            command.ShowProductByID(id);
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
            command.AddProduct(product);
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
            command.UpdateProduct(id, product);
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Enter product ID:");
            var id = int.Parse(Console.ReadLine());
            command.DeleteProduct(id);
        }
    }
}
