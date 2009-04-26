using System.Web.Mvc;
using System.Collections.Generic;
using MBlog.Data.Domain;
using MBlog.Data.DataAccess;
using System.Linq;
using MBlog.Service;

namespace MBlog.Web.Controllers {
    public class BlogController : Controller {

        IPostService _blogService;

        public BlogController(IPostService blogService) {
            _blogService = blogService;
        }

        public ActionResult Index() {
            var result = _blogService.GetAllPosts();
            return View(result);
        }

    }
}
