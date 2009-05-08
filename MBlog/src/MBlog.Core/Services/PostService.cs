using System.Collections.Generic;
using System.Linq;
using MBlog.Core.Domain.Model;
using MBlog.Core.Domain.DataAccess;

namespace MBlog.Core.Services {
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

        public void InsertPost(Post newPost) {
            _repository.Insert(newPost);
            _repository.Save();
        }
    }
}
