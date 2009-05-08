using MBlog.Core.Domain.DataAccess;

namespace MBlog.Core.Services {
    public class SiteService : ISiteService {

        private ISiteRepository _repository;

        public SiteService(ISiteRepository repository) {
            _repository = repository;
        }

        public string GetSiteName() {
            return _repository.GetSiteName();
        }
    }
}
