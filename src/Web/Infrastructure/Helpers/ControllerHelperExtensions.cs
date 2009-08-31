using MBlog.Web.Infrastructure.MVC;
using System.Web.Mvc;

namespace MBlog.Web.Infrastructure.Helpers {
    public static class ControllerHelperExtensions {
        public static UrlResult RedirectToUrl(this Controller controller, string url) {
            return new UrlResult { Url = url };
        }
    }
}
