using System.Web.Mvc;
using MBlog.Service;
using StructureMap;

namespace MBlog.Web.Infrastructure.Helpers {
    public static class HtmlHelperExtensions {
        private static ISiteService _siteService = ObjectFactory.GetInstance<ISiteService>();

        public static string GetSiteName(this HtmlHelper helper) {
            return _siteService.GetSiteName();
        }
    }
}

