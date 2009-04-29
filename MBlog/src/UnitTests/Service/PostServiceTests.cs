using System.Collections.Generic;
using System.Linq;
using MBlog.Data.DataAccess;
using MBlog.Data.Domain;
using MBlog.Service;
using MbUnit.Framework;
using Moq;
using MBlog.Tests.Mocks;

namespace MBlog.Tests.Service {
    /* Blog service tests:
     *  - Should be able to get all the posts
     *  - Should be able to get the 5 latest posts
     *  - Should be able to get a post by id
     */
    [TestFixture]
    public class PostServiceTests {
        PostService blogService;

        [FixtureSetUp]
        public void FixtureSetup() {
            blogService = new PostService(new TestBlogRepository());
        }

        [Test]
        public void GetPostsGetsAListOfBlogPosts() {
            var result = blogService.GetAllPosts();
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(typeof(IList<Post>), result);
        }

        [Test]
        public void GetAllPostsShouldReturnMoreThanOneBlogPost() {
            var result = blogService.GetAllPosts();
            Assert.IsTrue(result.Count > 0);
        }

        [Test]
        public void GetLatestPostsShouldReturnLessThanFivePosts() {
            var result = blogService.GetLatestPosts();
            Assert.IsTrue(result.Count() <= 5);
        }

        [Test]
        public void GetPostShouldBeAbleToGetPostById() {
            var result = blogService.GetPost(2);
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.ID);
        }
    }
}
