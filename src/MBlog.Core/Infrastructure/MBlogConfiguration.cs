namespace MBlog.Core.Infrastructure {
    internal class MBlogConfiguration {
        public static string ConnectionString {
            get {
                return Properties.Settings.Default.MBlogConnectionString;
            }
        }
    }
}