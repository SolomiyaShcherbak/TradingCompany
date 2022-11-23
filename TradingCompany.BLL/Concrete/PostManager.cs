using DAL.Concrete;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<PostDTO> FindPosts(string searchInfo)
        {
            return postDAL.FindPosts(searchInfo);
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
