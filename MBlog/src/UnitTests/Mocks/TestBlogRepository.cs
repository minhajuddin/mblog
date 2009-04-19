using MBlog.Data.DataAccess;
using MBlog.Data.Domain;
using System.Linq;
using System.Collections.Generic;
using System;

namespace MBlog.Tests.Mocks {
    class TestBlogRepository : IPostRepository {

        IList<Post> posts;

        public TestBlogRepository() {
            posts = new List<Post>();
            posts.Add(new Post
            {
                Title = "First Post",
                Content = "This is my First Post",
                Author = "Khaja Minhajuddin",
                Timestamp = DateTime.Now
            });
            posts.Add(new Post
            {
                Title = "MBlog releas of version 1.0",
                Content = "Happy to relese MBlog to the masses ;)",
                Author = "Khaja Minhajuddin",
                Timestamp = DateTime.Now
            });
        }


        public IQueryable<Post> GetPosts() {
            return posts.AsQueryable();
        }
    }
}
