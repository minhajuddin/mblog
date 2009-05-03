using System.Web.Mvc;
using System.Collections.Generic;
using MBlog.Data.Domain;
using MBlog.Data.DataAccess;
using System.Linq;
using MBlog.Service;
using MBlog.Web.Infrastructure.Helpers;
using MBlog.Web.Models.DTO;
using System;

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

        public ActionResult Create() {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(PostForm post) {
            var newPost = new Post { Title = post.Title, Content = post.Content };
            try {
                //TODO: Remove the hardcoded author name, Get it from the AppHelper
                newPost.Author = "Khaja Minhajuddin";
                newPost.Timestamp = DateTime.Now;
                _blogService.InsertPost(newPost);
            } catch {
                return View();
            }
            return RedirectToAction("Index");
        }

        //Url Shortener action forwards any incoming request to the proper url
        public ActionResult UrlShortener(int id) {
            var post = _blogService.GetPost(id);
            if (post == null) {
                return RedirectToAction("Index");
            }
            return this.RedirectToUrl(Url.GetPermaLink(post));
        }
    }
}