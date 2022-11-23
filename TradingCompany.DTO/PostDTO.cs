using System;
using System.Collections.Generic;

namespace TradingCompany.DTO
{
    public class PostDTO
    {
        public int PostID { get; set; }

        public int UserID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public List<ProductDTO> Products { get; set; }

        public DateTime RowInsertTime { get; set; }

        public DateTime RowUpdateTime { get; set; }

        public override string ToString()
        {
            return $"\nPost ID: {this.PostID}"
                + $"\nTitle: {this.Title}"
                + $"\nCreated date: {this.RowInsertTime}"
                + $"\nContent: \n{this.Content}";
        }
    }
}
