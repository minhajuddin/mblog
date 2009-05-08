using MbUnit.Framework;
using System.Linq;
using System;
using MBlog.Core.DataAccess;
using MBlog.Core.Domain.Model;

namespace MBlog.IntegrationTests.RepositoryTests {
    [TestFixture]
    public class PostRepositoryTests {

        PostRepository _repository;

        [FixtureSetUp]
        public void FixtureSetup() {
            _repository = new PostRepository();
        }

        [Test]
        public void GetPostsReturnsAnIQueryableOfBlogPosts() {
            var result = _repository.GetPosts();
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(typeof(IQueryable<Post>), result);
        }

        [Test]
        public void GetPostsReturnsAtLeastOneBlogPost() {
            var result = _repository.GetPosts();
            Assert.IsTrue(result.Count() > 1);
        }

        [Test]
        public void InsertPostInsertsAPostInTheDatabase() {
            var initialCount = _repository.GetPosts().Count();
            var post = new Post
            {
                Title = "Being inserted from the Test",
                Content = "And here is some content for you",
                Author = "Khaja",
                Timestamp = DateTime.Now.Date
            };
            _repository.Insert(post);
            _repository.Save();
            var result = _repository.GetPosts().Count();
            Assert.AreEqual(initialCount + 1, result);
        }
    }
}
