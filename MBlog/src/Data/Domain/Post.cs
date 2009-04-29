using System;

namespace MBlog.Data.Domain {
    public class Post {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Timestamp { get; set; }
        public string Gist {
            get {
                //returns the first 100 characters of the content
                var gist = Content.Length < 100 ? Content : Content.Substring(0, 100) + " ....";
                return gist;
            }
        }
    }
}
