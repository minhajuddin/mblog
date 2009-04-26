using MbUnit.Framework;
using System.Linq;
using MBlog.Data.Domain;
using MBlog.Data.DataAccess;

namespace MBlog.IntegrationTests.RepositoryTests {
    [TestFixture]
    public class PostRepositoryTests {
        [Test]
        public void GetPostsReturnsAnIQueryableOfBlogPosts() {
            PostRepository repo = new PostRepository();
            var result = repo.GetPosts();
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(typeof(IQueryable<Post>), result);
        }

        [Test]
        public void GetPostsReturnsAtLeastOneBlogPost() {
            PostRepository repo = new PostRepository();
            var result = repo.GetPosts();
            Assert.IsTrue(result.Count() > 1);
        }
    }
}
