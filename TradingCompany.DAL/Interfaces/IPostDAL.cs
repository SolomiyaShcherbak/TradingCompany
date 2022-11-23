﻿using System.Collections.Generic;
using TradingCompany.DTO;

namespace DAL.Interfaces
{
    public interface IPostDAL
    {
        List<PostDTO> GetAllPosts();

        PostDTO GetPostByID(int id);

        List<PostDTO> FindPosts(string searchInfo);

        PostDTO CreatePost(PostDTO post);

        PostDTO UpdatePost(int id, PostDTO post);

        PostDTO DeletePost(int id);
    }
}
