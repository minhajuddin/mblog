namespace MBlog.Data.DataAccess {
    public class SiteRepository : ISiteRepository {
        public string GetSiteName() {
            //TODO: Get the data from the database instead of hardcoding it
            return "My Experiences with this DLROW!";
        }
    }
}
