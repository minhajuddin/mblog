using MBlog.Data.Domain;
using System.Linq;

namespace MBlog.Data.DataAccess {
    public interface IPostRepository {
        IQueryable<Post> GetPosts();
        void Insert(Post newPost);
        void Save();
    }
}
