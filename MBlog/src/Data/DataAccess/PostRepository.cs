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
            return _db.Posts.Select(p => ConvertToDomainPost(p));
        }

        private Post ConvertToDomainPost(Entity.Post p) {
            return new Post
            {
                Title = p.Title,
                Content = p.Content,
                Author = p.Author,
                Timestamp = p.Timestamp
            };
        }
    }
}
