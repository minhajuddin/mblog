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
    }
}
