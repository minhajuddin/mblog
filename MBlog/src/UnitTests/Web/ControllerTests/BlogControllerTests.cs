using MbUnit.Framework;
using System.Collections.Generic;
using MBlog.Web.Controllers;
using System.Web.Mvc;
using MBlog.Data.Domain;
using MBlog.Service;
using Moq;
using MBlog.Tests.Mocks;
using MBlog.Web.Models.DTO;

namespace MBlog.Tests.Web.ControllerTests {
    /* BlogController Tests:
     *  - Index action returns a list of blog posts
     * 
     */


    [TestFixture]
    public class BlogControllerTests {

        BlogController blogController;

        [FixtureSetUp]
        public void FixtureSetup() {
            blogController = new BlogController(new PostService(new TestBlogRepository()));
        }

        [Test]
        public void IndexActionReturnsAListOfBlogPosts() {
            var result = blogController.Index() as ViewResult;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(typeof(IList<Post>), result.ViewData.Model);
        }

        [Test]
        public void IndexActionReturnsMoreThanOneBlogPost() {
            var viewResult = blogController.Index() as ViewResult;
            var result = viewResult.ViewData.Model as IList<Post>;
            Assert.IsTrue(result.Count > 0);
        }

        [Test]
        public void CreateActionShouldCallTheInsertPostMethodOnTheServiceSuccessfully() {
            Mock<IPostService> postService = new Mock<IPostService>();
            var controller = new BlogController(postService.Object);

            var post = new PostForm { Title = "Title from a test", Content = "Test Content" };
            var result = controller.Create(post) as ViewResult;

            postService.Verify(x => x.InsertPost(It.IsAny<Post>()), Times.Exactly(1));
        }
    }
}