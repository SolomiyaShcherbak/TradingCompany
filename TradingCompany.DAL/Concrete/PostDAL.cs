using AutoMapper;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TradingCompany.DTO;

namespace DAL.Concrete
{
    public class PostDAL : IPostDAL
    {
        private readonly IMapper _mapper;

        public PostDAL(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<PostDTO> GetAllPosts()
        {
            using (var entities = new TradingCompanyEntities())
            {
                var posts = entities.Posts.ToList();
                return _mapper.Map<List<PostDTO>>(posts);
            }
        }

        public PostDTO GetPostByID(int id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var existPost = entities.Posts.Any(p => p.PostID == id);
                Post postInDB;
                if (existPost)
                {
                    postInDB = entities.Posts.FirstOrDefault(x => x.PostID == id);
                    return _mapper.Map<PostDTO>(postInDB);
                }
                else
                {
                    return null;
                }
            }
        }

        public List<PostDTO> FindPostsByTitle(string title)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var posts = entities.Posts.Where(p => p.Title.Contains(title)).ToList();
                return _mapper.Map<List<PostDTO>>(posts);
            }
        }

        public List<PostDTO> FindPostsByContent(string content)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var posts = entities.Posts.Where(p => p.Content.Contains(content)).ToList();
                return _mapper.Map<List<PostDTO>>(posts);
            }
        }

        public List<PostDTO> FindPostsByDate(string date)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var posts = entities.Posts.Where(p => p.RowUpdateTime.ToString().Contains(date)).ToList();
                return _mapper.Map<List<PostDTO>>(posts);
            }
        }

        public PostDTO CreatePost(PostDTO post)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var postInDB = _mapper.Map<Post>(post);
                entities.Posts.Add(postInDB);
                entities.SaveChanges();
                return _mapper.Map<PostDTO>(postInDB);
            }
        }

        public PostDTO UpdatePost(int id, PostDTO post)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var existPost = entities.Posts.Any(p => p.PostID == id);
                Post postToUpdate;
                if (existPost)
                {
                    postToUpdate = entities.Posts.FirstOrDefault(x => x.PostID == id);
                    postToUpdate.Title = post.Title;
                    postToUpdate.Content = post.Content;
                    postToUpdate.RowUpdateTime = DateTime.UtcNow;
                    postToUpdate = _mapper.Map(post, postToUpdate);
                    entities.Entry(postToUpdate).State = EntityState.Modified;
                    entities.SaveChanges();
                    return _mapper.Map<PostDTO>(postToUpdate);
                }
                else
                {
                    return null;
                }
            }
        }

        public PostDTO DeletePost(int id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var existPost = entities.Posts.Any(p => p.PostID == id);
                Post postInDB;
                if (existPost)
                {
                    postInDB = entities.Posts.FirstOrDefault(c => c.PostID == id);
                    entities.Posts.Remove(postInDB);
                    entities.SaveChanges();
                    return _mapper.Map<PostDTO>(postInDB);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
