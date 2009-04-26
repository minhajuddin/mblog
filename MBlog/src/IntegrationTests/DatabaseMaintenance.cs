using MbUnit.Framework;
using MBlog.Data.DataAccess.Context;
using System.Linq;
using MBlog.Data.DataAccess.Entity;
using System;

namespace MBlog.IntegrationTests {
    //TODO:Find a better way to do Data maintenance
    [TestFixture]
    [Ignore]
    public class DatabaseMaintenance {

        [Test]
        public void CreateDatabaseWithTestData() {
            MBlogRepositoryDataContext dataContext = new MBlogRepositoryDataContext();

            //Delete database if it already exists
            if (dataContext.DatabaseExists()) {
                dataContext.DeleteDatabase();
            }

            //Create the database
            dataContext.CreateDatabase();

            //Populate the database with some fake data
            dataContext.Posts.InsertAllOnSubmit(
                new[]{
                        new Post{
                            Title = "First Post", 
                            Content = "This is the first blog post, and it's very short", 
                            Author = "Khaja Minhajuddin", 
                            Timestamp = DateTime.Now
                        },
                        new Post{
                            Title = "MBlog set to conquer the world", 
                            Content = "Now that, was supposed to be an April Fool's joke ;)", 
                            Author = "Khaja Minhajuddin", 
                            Timestamp = DateTime.Now
                        },
                        new Post{
                            Title = "MBlog the latest blogging framework written using ASP.NET MVC", 
                            Content = "This has been a great year for the MBlog application, it has been getting some good reviews!", 
                            Author = "Khaja Minhajuddin", 
                            Timestamp = DateTime.Now
                        }
            });
            dataContext.SubmitChanges();

        }
    }
}
