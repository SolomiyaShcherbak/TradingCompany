using System;

namespace TradingCompany
{
    public class VisualMenu
    {
        public void ShowMainMenu()
        {
            string menu = @"
Select an option:
1: CRUD operations with news
2: CRUD operations with products
3: CRUD operations with categories
0: Exit";
            Console.WriteLine(menu);
        }

        public void ShowNewsCRUDOperationsMenu()
        {
            string menu = @"
CRUD operations with news:
1: Create news
2: Update news
3: Delete news
4: Show all news
5: Show news by ID
0: Back";
            Console.WriteLine(menu);
        }

        public void ShowProductsCRUDOperationsMenu()
        {
            string menu = @"
CRUD operations with products:
1: Create product
2: Update product
3: Delete product
4: Show all products
5: Show product by ID
0: Back";
            Console.WriteLine(menu);
        }

        public void ShowCategoriesCRUDOperationsMenu()
        {
            string menu = @"
CRUD operations with categories:
1: Create category
2: Update category
3: Delete category
4: Show all categories
5: Show category by ID
0: Back";
            Console.WriteLine(menu);
        }
    }
}

