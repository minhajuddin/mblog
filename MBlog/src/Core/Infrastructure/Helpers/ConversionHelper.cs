using MBlog.Core.Domain;
using Entity = MBlog.Core.Domain.DataAccess.Entity;
using MBlog.Core.Domain.Model;

namespace MBlog.Core.Infrastructure {

    public static class ConversionHelper {
        public static Post ToDomainPost(this Entity.Post p) {
            return new Post
            {
                ID = p.PostID,
                Title = p.Title,
                Content = p.Content,
                Author = p.Author,
                Timestamp = p.Timestamp
            };
        }

        public static MBlog.Core.Domain.DataAccess.Entity.Post ToEntityPost(this Post p) {
            return new Entity.Post
            {
                PostID = p.ID,
                Title = p.Title,
                Content = p.Content,
                Author = p.Author,
                Timestamp = p.Timestamp
            };
        }
    }

}
