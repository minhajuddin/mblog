using System.Web.Mvc;
using MBlog.Core.Services;
using StructureMap;

namespace MBlog.Web.Infrastructure.Helpers {
    public static class HtmlHelperExtensions {
        private static ISiteService _siteService = ObjectFactory.GetInstance<ISiteService>();

        public static string GetSiteName(this HtmlHelper helper) {
            return _siteService.GetSiteName();
        }

        public static string Anchor(this HtmlHelper helper, string url) {
            return Anchor(helper, url, url, url);
        }

        public static string Anchor(this HtmlHelper helper, string url, string text) {
            return Anchor(helper, url, text, text);
        }

        public static string Anchor(this HtmlHelper helper, string url, string text, string title) {
            return string.Format("<a href=\"{0}\" title=\"{1}\">{2}</a>", url, title, text);
        }
    }
}

