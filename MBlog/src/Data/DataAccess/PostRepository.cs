using MBlog.Data.Domain;
using System.Linq;
using System.Collections.Generic;
using MBlog.Data.DataAccess.Context;

namespace MBlog.Data.DataAccess {

    public class PostRepository : IPostRepository {

        MBlogRepositoryDataContext _db;

        public PostRepository() {
            _db = new MBlogRepositoryDataContext(MBlogConfiguration.ConnectionString);
        }

        public IQueryable<Post> GetPosts() {
            return _db.Posts
                .OrderByDescending(x => x.Timestamp)
                //TODO: Fix this by using the extension method
                //.Select(p => p.ToDomainPost());
                .Select(
                p => new Post
                {
                    ID = p.PostID,
                    Title = p.Title,
                    Author = p.Author,
                    Timestamp = p.Timestamp,
                    Content = p.Content
                });
        }


    }
}