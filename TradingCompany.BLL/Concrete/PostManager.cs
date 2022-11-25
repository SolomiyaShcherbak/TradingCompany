using DAL.Interfaces;
using System.Collections.Generic;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Concrete
{
    public class PostManager : IPostManager
    {
        private readonly IPostDAL postDAL;

        public PostManager(IPostDAL postDAL)
        {
            this.postDAL = postDAL;
        }

        public List<PostDTO> GetAllPosts()
        {
            return postDAL.GetAllPosts();
        }

        public PostDTO GetPostByID(int id)
        {
            return postDAL.GetPostByID(id);
        }

        public List<PostDTO> FindPostsByTitle(string title)
        {
            return postDAL.FindPostsByTitle(title);
        }

        public List<PostDTO> FindPostsByContent(string content)
        {
            return postDAL.FindPostsByContent(content);
        }

        public List<PostDTO> FindPostsByDate(string date)
        {
            return postDAL.FindPostsByDate(date);
        }

        public PostDTO CreatePost(PostDTO post)
        {
            return postDAL.CreatePost(post);
        }

        public PostDTO UpdatePost(int id, PostDTO post)
        {
            return postDAL.UpdatePost(id, post);
        }

        public PostDTO DeletePost(int id)
        {
            return postDAL.DeletePost(id);
        }
    }
}
