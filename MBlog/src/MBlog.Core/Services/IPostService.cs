using System.Collections.Generic;
using MBlog.Core.Domain;
using MBlog.Core.Domain.Model;

namespace MBlog.Core.Services {

    public interface IPostService {
        IList<Post> GetAllPosts();
        IList<Post> GetLatestPosts();
        Post GetPost(int postId);
        void InsertPost(Post newPost);
    }
}
