using System;

namespace MBlog.Data.Domain {
    public class Post {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Timestamp { get; set; }
        public string Gist {
            get {
                return Content.Substring(0, 100) + " ....";
            }
        }
    }
}
