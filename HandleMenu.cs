using System;

namespace TradingCompany
{
    public class HandleMenu
    {
        VisualMenu visualMenu;
        ActionMenu actionMenu;

        public HandleMenu()
        {
            visualMenu = new VisualMenu();
            actionMenu = new ActionMenu();
        }

        public void HandleStartMenu()
        {
            string userInput = "";
            do
            {
                visualMenu.ShowMainMenu();
                userInput = Console.ReadLine();
                HandleMainMenu(userInput);
            }
            while (userInput != "0");
        }

        private void HandleMainMenu(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    do
                    {
                        visualMenu.ShowNewsCRUDOperationsMenu();
                        userInput = Console.ReadLine();
                        HandleNewsCRUDOperationsMenu(userInput);
                    } while (userInput != "0");
                    break;
                case "2":
                    do
                    {
                        visualMenu.ShowProductsCRUDOperationsMenu();
                        userInput = Console.ReadLine();
                        HandleProductsCRUDOperationsMenu(userInput);
                    } while (userInput != "0");
                    break;
                case "3":
                    do
                    {
                        visualMenu.ShowCategoriesCRUDOperationsMenu();
                        userInput = Console.ReadLine();
                        HandleCategoriesCRUDOperationsMenu(userInput);
                    } while (userInput != "0");
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Invalid option\n");
                    break;
            }
        }

        private void HandleNewsCRUDOperationsMenu(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    actionMenu.AddPost();
                    break;
                case "2":
                    actionMenu.UpdatePost();
                    break;
                case "3":
                    actionMenu.DeletePost();
                    break;
                case "4":
                    actionMenu.ShowAllPosts();
                    break;
                case "5":
                    actionMenu.ShowPostByID();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Invalid option\n");
                    break;
            }
        }

        private void HandleProductsCRUDOperationsMenu(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    actionMenu.AddProduct();
                    break;
                case "2":
                    actionMenu.UpdateProduct();
                    break;
                case "3":
                    actionMenu.DeleteProduct();
                    break;
                case "4":
                    actionMenu.ShowAllProducts();
                    break;
                case "5":
                    actionMenu.ShowProductByID();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Invalid option\n");
                    break;
            }
        }

        private void HandleCategoriesCRUDOperationsMenu(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    actionMenu.AddCategory();
                    break;
                case "2":
                    actionMenu.UpdateCategory();
                    break;
                case "3":
                    actionMenu.DeleteCategory();
                    break;
                case "4":
                    actionMenu.ShowAllCategories();
                    break;
                case "5":
                    actionMenu.ShowCategoryByID();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Invalid option\n");
                    break;
            }
        }
    }
}
