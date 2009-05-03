using System.Web.Mvc;

namespace MBlog.Web.Infrastructure.Helpers {
    public static class UrlHelperExtensions {
        public static string GetCSS(this UrlHelper helper, string filename) {
            var cssUrl = helper.Content(string.Format("~/Content/css/{0}", filename));
            return cssUrl;
        }
    }
}
