using System.Web.Mvc;

namespace MBlog.Web.Infrastructure.MVC {
    public class UrlResult : ActionResult {
        public string Url { get; set; }

        public override void ExecuteResult(ControllerContext context) {
            if (string.IsNullOrEmpty(Url) || Url.Trim().Length == 0) {
                throw new System.ArgumentException("Invalid Url");
            }
            context.HttpContext.Response.Redirect(Url);
        }
    }
}
