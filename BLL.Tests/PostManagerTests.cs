using System;
using Moq;
using NUnit.Framework;
using DAL.Interfaces;
using TradingCompany.BLL.Concrete;
using TradingCompany.DTO;

namespace BLL.Tests
{
    [TestFixture]
    public class PostManagerTests
    {
        private Mock<IPostDAL> postDAL;
        private PostManager manager;

        [SetUp]
        public void Setup()
        {
            postDAL = new Mock<IPostDAL>(MockBehavior.Strict);
            manager = new PostManager(postDAL.Object);
        }

        [Test]
        public void AddPostTest()
        {
            var inPost = new PostDTO
            {
                Title = "test title",
                Content = "test content",
                RowInsertTime = DateTime.UtcNow,
                RowUpdateTime = DateTime.UtcNow
            };
            var outPost = new PostDTO { PostID = 1 };

            postDAL.Setup(d => d.CreatePost(inPost)).Returns(outPost);
            var result = manager.CreatePost(inPost);

            Assert.IsNotNull(result);
            Assert.AreEqual(outPost.PostID, result.PostID);
        }

        [Test]
        public void GetPostByID_ValidID()
        {
            var outPost = new PostDTO { PostID = 1 };
            postDAL.Setup(p => p.GetPostByID(1)).Returns(outPost);
            PostDTO result = manager.GetPostByID(1);
            Assert.AreEqual(outPost.PostID, result.PostID);
        }

        [Test]
        public void GetPostByID_InvalidID()
        {
            var outPost = (PostDTO)null;
            postDAL.Setup(p => p.GetPostByID(-1)).Returns(outPost);
            PostDTO result = manager.GetPostByID(-1);
            Assert.AreEqual(outPost, result);
        }

        [Test]
        public void DeletePost_ValidID()
        {
            var outPost = new PostDTO { PostID = 1 };
            postDAL.Setup(p => p.DeletePost(1)).Returns(outPost);
            PostDTO result = manager.DeletePost(1);
            Assert.AreEqual(outPost, result);
        }

        [Test]
        public void DeletePost_InvalidID()
        {
            var outPost = (PostDTO)null;
            postDAL.Setup(p => p.DeletePost(-1)).Returns(outPost);
            PostDTO result = manager.DeletePost(-1);
            Assert.AreEqual(outPost, result);
        }
    }
}
