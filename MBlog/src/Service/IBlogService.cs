using System.Collections.Generic;
using MBlog.Data.Domain;

namespace MBlog.Service {
    public interface IBlogService {
        IList<Post> GetAllPosts();
    }
}
