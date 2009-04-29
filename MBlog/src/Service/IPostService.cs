using System.Collections.Generic;
using MBlog.Data.Domain;

namespace MBlog.Service {

    public interface IPostService {
        IList<Post> GetAllPosts();
        IList<Post> GetLatestPosts();
        Post GetPost(int postId);
    }
}
