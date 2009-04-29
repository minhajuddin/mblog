using System.Collections.Generic;
using MBlog.Data.DataAccess;
using MBlog.Data.Domain;
using System.Linq;

namespace MBlog.Service {
    public class PostService : IPostService {
        private IPostRepository _repository;

        public PostService(IPostRepository repository) {
            _repository = repository;
        }

        public IList<Post> GetAllPosts() {
            var result = _repository.GetPosts();
            return result.ToList();
        }

        public IList<Post> GetLatestPosts() {
            var result = _repository.GetPosts()
                .Take(5).ToList();
            return result;
        }

        public Post GetPost(int postId) {
            var post = _repository.GetPosts()
                .SingleOrDefault(x => x.ID == postId);
            return post;
        }
    }
}
