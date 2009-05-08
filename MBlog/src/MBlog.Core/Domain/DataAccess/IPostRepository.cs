using MBlog.Core.Domain.Model;
using System.Linq;

namespace MBlog.Core.Domain.DataAccess {
    public interface IPostRepository {
        IQueryable<Post> GetPosts();
        void Insert(Post newPost);
        void Save();
    }
}
