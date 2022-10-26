using AutoMapper;
using DAL.Concrete;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using TradingCompany.DTO;
using System.Data.Entity.Validation;
using System.Linq;

namespace DAL.Tests
{
    [TestFixture]
    public class PostDALTests
    {
        private IMapper _mapper;

        [OneTimeSetUp]
        public void SetupMapper()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(PostDAL).Assembly)
                );
            _mapper = config.CreateMapper();
        }

        [Test, Rollback]
        public void Test_GetAllPosts_ValidOutput()
        {
            InsertPostIntoDatabase();
            var postDAL = new PostDAL(_mapper);

            var posts = postDAL.GetAllPosts();

            Assert.AreEqual(1, posts.Count);
        }

        [Test, Rollback]
        public void Test_GetAllPosts_EmptyList()
        {
            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Post]");
            }
            var postDAL = new PostDAL(_mapper);

            var posts = postDAL.GetAllPosts();

            Assert.IsTrue(posts.Count == 0);
        }

        [Test, Rollback]
        public void Test_GetPostByID_ValidID()
        {
            var post = InsertPostIntoDatabase();
            var postDAL = new PostDAL(_mapper);

            var result = postDAL.GetPostByID(post.PostID);

            var isoConvert = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            var expectedString = JsonConvert.SerializeObject(post, isoConvert);
            var actualString = JsonConvert.SerializeObject(result, isoConvert);

            Assert.AreEqual(expectedString, actualString);
        }

        [Test, Rollback]
        public void Test_GetPostByID_InvalidID()
        {
            var postDAL = new PostDAL(_mapper);
            var result = postDAL.GetPostByID(-1);

            Assert.IsNull(result);
        }

        [Test, Rollback]
        public void Test_CreatePost_ValidData()
        {
            var post = InsertPostIntoDatabase();

            Assert.IsTrue(post.PostID > 0);
        }

        [Test, Rollback]
        public void Test_CreatePost_InvalidData()
        {
            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Post]");
            }

            var postDAL = new PostDAL(_mapper);
            var post = new PostDTO
            {
                Title = RandomString(301),
                Content = "test content",
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };

            Assert.Throws<DbEntityValidationException>(() => postDAL.CreatePost(post));
        }

        [Test, Rollback]
        public void Test_UpdatePost_ValidData()
        {
            var postDAL = new PostDAL(_mapper);
            var post = InsertPostIntoDatabase();

            var updatedPost = new PostDTO
            {
                Title = "test title updated",
                Content = "test content updated",
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };

            var result = postDAL.UpdatePost(post.PostID, updatedPost);

            Assert.AreEqual(post.PostID, result.PostID);
            Assert.AreEqual(updatedPost.Title, result.Title);
            Assert.AreEqual(updatedPost.Content, result.Content);
        }

        [Test, Rollback]
        public void Test_UpdatePost_InvalidData()
        {
            var postDAL = new PostDAL(_mapper);
            var post = InsertPostIntoDatabase();

            var updatedPost = new PostDTO
            {
                Title = RandomString(302),
                Content = "test content updated",
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };

            Assert.Throws<DbEntityValidationException>(() => postDAL.UpdatePost(post.PostID, updatedPost));
        }

        [Test, Rollback]
        public void Test_DeletePost_ValidID()
        {
            var postDAL = new PostDAL(_mapper);
            var post = InsertPostIntoDatabase();

            var result = postDAL.DeletePost(post.PostID);

            var isoConvert = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            var expectedString = JsonConvert.SerializeObject(post, isoConvert);
            var actualString = JsonConvert.SerializeObject(result, isoConvert);

            Assert.AreEqual(expectedString, actualString);
            Assert.AreEqual(0, postDAL.GetAllPosts().Count);
        }

        [Test, Rollback]
        public void Test_DeletePost_InvalidID()
        {
            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Post]");
            }

            var postDAL = new PostDAL(_mapper);

            Assert.IsNull(postDAL.DeletePost(1));
        }

        private PostDTO InsertPostIntoDatabase()
        {
            using (var context = new TradingCompanyEntities())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [Post]");
            }

            var postDAL = new PostDAL(_mapper);
            var post = new PostDTO
            {
                Title = "test title",
                Content = "test content",
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };

            return postDAL.CreatePost(post);
        }

        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
