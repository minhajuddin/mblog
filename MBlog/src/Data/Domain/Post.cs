using System;
using System.Text;

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
        public string Slug {
            get {
                //returns the title by replacing a few weird characters
                var arr = Title.Split(" ".ToCharArray());
                var sb = new StringBuilder();
                foreach (var token in arr) {
                    sb.AppendFormat("{0}-", token);
                }
                var result = sb.ToString();
                //Substring to remove the last hyphen
                return result.Substring(0, result.Length - 1);
            }
        }
    }
}
