using MbUnit.Framework;
using System;
using MBlog.Data.Domain;
namespace MBlog.Tests.Data.DomainTests {
    /* Tests for the BlogPost class:
     *  - Blog post needs to have a Title, Content, Author and a Timestamp
     *  - Post needs to have a Gist not more than 100 characters long
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

        [Test]
        public void GistIsEqualTo100CharactersWhenContentIsGreaterThan100Characters() {
            var blogPost = new Post
            {
                Title = "Test Title",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi ligula. Duis non mauris ut enim ultricies sagittis. Proin varius, dolor quis malesuada auctor, diam elit pulvinar libero, nec laoreet nibh quam quis tellus. Praesent et eros. Nam sagittis tortor ut tortor. Aenean egestas, nisi ac luctus elementum, tortor turpis congue diam, vel pellentesque magna neque sed justo. Nullam congue enim eu quam. Aliquam euismod pulvinar mi. Duis libero turpis, rutrum convallis, posuere nec, tincidunt non, neque. Morbi a nisl. Proin eu leo. Vivamus dictum turpis vel magna. Nam vitae tortor vitae tortor consectetur consectetur. ",
                Author = "Minhajuddin",
                Timestamp = DateTime.Now
            };

            var result = blogPost.Gist.Length;
            Assert.AreApproximatelyEqual(100, result, 10);
        }

        [Test]
        public void GistHasALengthEqualToLengthOfContentWhenContentLengthIsLessThan100Characters() {
            var blogPost = new Post
            {
                Title = "Test Title",
                Content = "Test Content",
                Author = "Minhajuddin",
                Timestamp = DateTime.Now
            };

            var expected = blogPost.Content.Length;
            var result = blogPost.Gist.Length;
            Assert.AreEqual(expected, result);
        }
    }
}

