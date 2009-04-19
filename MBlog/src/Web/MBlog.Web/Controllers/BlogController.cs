using System.Web.Mvc;
using System.Collections.Generic;
using MBlog.Data.Domain;
using MBlog.Data.DataAccess;
using System.Linq;
using MBlog.Service;

namespace MBlog.Web.Controllers {
    public class BlogController : Controller {

        IBlogService _blogService;

        public BlogController(IBlogService blogService) {
            _blogService = blogService;
        }

        public ActionResult Index() {
            var result = _blogService.GetAllPosts();
            return View(result);
        }

    }
}
