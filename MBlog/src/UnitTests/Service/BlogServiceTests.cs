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
     * 
     */
    [TestFixture]
    public class BlogServiceTests {
        BlogService blogService;

        [FixtureSetUp]
        public void FixtureSetup() {
            blogService = new BlogService(new TestBlogRepository());
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
    }
}
