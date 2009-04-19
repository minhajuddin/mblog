using MbUnit.Framework;
using System;
using MBlog.Data.Domain;
namespace MBlog.Tests.Data.DomainTests {
    /* Tests for the BlogPost class:
     *  - Blog post needs to have a Title, Content, Author and a Timestamp
     *  - 
     * 
     */
    [TestFixture]
    public class BlogPostTests {
        [Test]
        public void CanCreateABlogPostWithAnEmptyConstructor() {
            var blogPost = new Post();
            Assert.IsNotNull(blogPost);
        }

        [Test]
        public void HasATitleContentAuthorAndATimestamp() {
            DateTime blogPostTimestamp = DateTime.Now;
            var blogPost = new Post
            {
                Title = "Test Title",
                Content = "Test Content",
                Author = "Minhajuddin",
                Timestamp = blogPostTimestamp
            };

            Assert.AreEqual("Test Title", blogPost.Title);
            Assert.AreEqual("Test Content", blogPost.Content);
            Assert.AreEqual("Minhajuddin", blogPost.Author);
            Assert.AreEqual(blogPostTimestamp, blogPost.Timestamp);
        }
    }
}
