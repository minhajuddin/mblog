using System.Web.Mvc;
using System.Collections.Generic;
using MBlog.Data.Domain;
using MBlog.Data.DataAccess;
using System.Linq;
using MBlog.Service;
using MBlog.Web.Infrastructure.Helpers;

namespace MBlog.Web.Controllers {
    public class BlogController : Controller {

        IPostService _blogService;

        public BlogController(IPostService blogService) {
            _blogService = blogService;
        }

        public ActionResult Index() {
            var result = _blogService.GetLatestPosts();
            return View(result);
        }

        public ActionResult Post(int id, string title) {
            var post = _blogService.GetPost(id);
            return View(post);
        }

        public ActionResult UrlShortener(int id) {
            var post = _blogService.GetPost(id);
            if (post == null) {
                return RedirectToAction("Index");
            }
            return this.RedirectToUrl(Url.GetPermaLink(post));
        }
    }
}
