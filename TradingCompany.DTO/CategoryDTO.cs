using System;

namespace TradingCompany.DTO
{
    public class CategoryDTO
    {
        public int CategoryID { get; set; }

        public string Name { get; set; }

        public DateTime RowInsertTime { get; set; }

        public override string ToString()
        {
            return $"\nCategory ID: {this.CategoryID}"
                + $"\nName: {this.Name}"
                + $"\nCreated date: {this.RowInsertTime}";
        }
    }
}
