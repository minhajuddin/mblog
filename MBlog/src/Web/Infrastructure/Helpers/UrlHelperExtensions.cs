using System.Web.Mvc;
using MBlog.Data.Domain;

namespace MBlog.Web.Infrastructure.Helpers {
    public static class UrlHelperExtensions {
        public static string GetCSS(this UrlHelper helper, string filename) {
            var cssUrl = helper.Content(string.Format("~/Content/css/{0}", filename));
            return cssUrl;
        }

        public static string GetPermaLink(this UrlHelper helper, Post post) {
            var permaLink = helper.Action("Post", new { id = post.ID, title = post.Slug });
            return permaLink;
        }

        public static string GetShortenedUrl(this UrlHelper helper, Post post) {
            var shortenedUrl = helper.Action("UrlShortener", new { id = post.ID });
            return shortenedUrl;
        }
    }
}
