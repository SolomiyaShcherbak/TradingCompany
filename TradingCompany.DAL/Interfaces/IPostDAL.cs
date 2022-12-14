using System.Collections.Generic;
using TradingCompany.DTO;

namespace DAL.Interfaces
{
    public interface IPostDAL
    {
        List<PostDTO> GetAllPosts();

        PostDTO GetPostByID(int id);

        List<PostDTO> FindPostsByTitle(string title);

        List<PostDTO> FindPostsByContent(string content);

        List<PostDTO> FindPostsByDate(string date);

        PostDTO CreatePost(PostDTO post);

        PostDTO UpdatePost(int id, PostDTO post);

        PostDTO DeletePost(int id);
    }
}
