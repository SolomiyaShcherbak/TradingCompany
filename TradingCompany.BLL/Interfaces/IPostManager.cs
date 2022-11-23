using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Interfaces
{
    public interface IPostManager
    {
        List<PostDTO> GetAllPosts();

        PostDTO GetPostByID(int id);

        List<PostDTO> FindPosts(string searchInfo);

        PostDTO CreatePost(PostDTO post);

        PostDTO UpdatePost(int id, PostDTO post);

        PostDTO DeletePost(int id);
    }
}
