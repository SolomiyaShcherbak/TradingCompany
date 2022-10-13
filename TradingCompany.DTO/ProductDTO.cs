using System;

namespace TradingCompany.DTO
{
    public class ProductDTO
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public int CategoryID { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTime RowInsertTime { get; set; }

        public DateTime RowUpdateTime { get; set; }

        public override string ToString()
        {
            return $"\nProduct ID: {this.ProductID}"
                + $"\nName: {this.Name}"
                + $"\nPrice: {this.Price}"
                + $"\nCreated date: {this.RowInsertTime}";
        }
    }
}
