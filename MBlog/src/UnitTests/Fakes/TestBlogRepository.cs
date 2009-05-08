using System.Linq;
using System.Collections.Generic;
using System;
using MBlog.Core.Domain.DataAccess;
using MBlog.Core.Domain.Model;

namespace MBlog.Tests.Mocks {
    class TestBlogRepository : IPostRepository {

        IList<Post> posts;

        public TestBlogRepository() {
            posts = new List<Post>();
            posts.Add(new Post
            {
                ID = 1,
                Title = "First Post",
                Content = "This is my First Post",
                Author = "Khaja Minhajuddin",
                Timestamp = DateTime.Now
            });
            posts.Add(new Post
            {
                ID = 2,
                Title = "MBlog releas of version 1.0",
                Content = "Happy to relese MBlog to the masses ;)",
                Author = "Khaja Minhajuddin",
                Timestamp = DateTime.Now
            });
            posts.Add(new Post
            {
                ID = 3,
                Title = "MBlog releas of version 1.0",
                Content = "Happy to relese MBlog to the masses ;)",
                Author = "Khaja Minhajuddin",
                Timestamp = DateTime.Now
            });
            posts.Add(new Post
            {
                ID = 4,
                Title = "MBlog releas of version 1.0",
                Content = "Happy to relese MBlog to the masses ;)",
                Author = "Khaja Minhajuddin",
                Timestamp = DateTime.Now
            });
            posts.Add(new Post
            {
                ID = 5,
                Title = "MBlog releas of version 1.0",
                Content = "Happy to relese MBlog to the masses ;)",
                Author = "Khaja Minhajuddin",
                Timestamp = DateTime.Now
            });
            posts.Add(new Post
            {
                ID = 6,
                Title = "MBlog releas of version 1.0",
                Content = "Happy to relese MBlog to the masses ;)",
                Author = "Khaja Minhajuddin",
                Timestamp = DateTime.Now
            });
            posts.Add(new Post
            {
                ID = 7,
                Title = "MBlog releas of version 1.0",
                Content = "Happy to relese MBlog to the masses ;)",
                Author = "Khaja Minhajuddin",
                Timestamp = DateTime.Now
            });
            posts.Add(new Post
            {
                ID = 8,
                Title = "MBlog releas of version 1.0",
                Content = "Happy to relese MBlog to the masses ;)",
                Author = "Khaja Minhajuddin",
                Timestamp = DateTime.Now
            });
        }


        public IQueryable<Post> GetPosts() {
            return posts.AsQueryable();
        }

        public void Insert(Post newPost) {
            posts.Add(newPost);
        }

        public void Save() {

        }
    }
}
