using System;

namespace TradingCompany
{
    public class HandleMenu : ActionsMenu
    {
        private VisualMenu visualMenu;

        public HandleMenu()
        {
            visualMenu = new VisualMenu();
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
                    AddNews();
                    break;
                case "2":
                    UpdateNews();
                    break;
                case "3":
                    DeleteNews();
                    break;
                case "4":
                    ShowAllNews();
                    break;
                case "5":
                    ShowNewsByID();
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
                    AddProduct();
                    break;
                case "2":
                    UpdateProduct();
                    break;
                case "3":
                    DeleteProduct();
                    break;
                case "4":
                    ShowAllProducts();
                    break;
                case "5":
                    ShowProductByID();
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
                    AddCategory();
                    break;
                case "2":
                    UpdateCategory();
                    break;
                case "3":
                    DeleteCategory();
                    break;
                case "4":
                    ShowAllCategories();
                    break;
                case "5":
                    ShowCategoryByID();
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
