using DAL.Interfaces;
using System.Collections.Generic;
using TradingCompany.DTO;

namespace TradingCompany.BLL
{
    public class Command
    {
        IProductDAL productDAL;
        ICategoryDAL categoryDAL;
        IPostDAL postDAL;

        public Command(IProductDAL itemDAL, ICategoryDAL categoryDAL, IPostDAL postDAL)
        {
            this.productDAL = itemDAL;
            this.categoryDAL = categoryDAL;
            this.postDAL = postDAL;
        }

        public List<ProductDTO> GetAllProducts()
        {
            return productDAL.GetAllProducts();
        }

        public ProductDTO GetProductByID(int id)
        {
            return productDAL.GetProductByID(id);
        }

        public ProductDTO AddProduct(ProductDTO product)
        {
            return productDAL.CreateProduct(product);
        }

        public ProductDTO UpdateProduct(int id, ProductDTO product)
        {
            return productDAL.UpdateProduct(id, product);
        }

        public void DeleteProduct(int id)
        {
            productDAL.DeleteProduct(id);
        }

        public List<PostDTO> GetAllPosts()
        {
            return postDAL.GetAllPosts();
        }

        public PostDTO GetPostByID(int id)
        {
            return postDAL.GetPostByID(id);
        }

        public PostDTO AddPost(PostDTO post)
        {
            return postDAL.CreatePost(post);
        }

        public PostDTO UpdatePost(int id, PostDTO post)
        {
            return postDAL.UpdatePost(id, post);
        }

        public void DeletePost(int id)
        {
            postDAL.DeletePost(id);
        }

        public List<CategoryDTO> GetAllCategories()
        {
            return categoryDAL.GetAllCategories();
        }

        public CategoryDTO GetCategoryByID(int id)
        {
            return categoryDAL.GetCategoryByID(id);
        }

        public CategoryDTO AddCategory(CategoryDTO category)
        {
            return categoryDAL.CreateCategory(category);
        }

        public CategoryDTO UpdateCategory(int id, CategoryDTO category)
        {
            return categoryDAL.UpdateCategory(id, category);
        }

        public void DeleteCategory(int id)
        {
            categoryDAL.DeleteCategory(id);
        }
    }
}
