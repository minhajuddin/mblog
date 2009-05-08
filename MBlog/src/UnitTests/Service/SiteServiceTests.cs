using MbUnit.Framework;
using StructureMap;
using MBlog.Web.BootStrap;
using MBlog.Core.Services;

namespace MBlog.Tests.Service {

    [TestFixture]
    public class SiteServiceTests {

        [FixtureSetUp]
        public void FixtureSetup() {
            BootStrapper.ConfigureStructureMap();
        }

        [Test]
        public void SiteServiceGetInstanceReturnsASingleInstanceOfSiteService() {
            var siteService1 = ObjectFactory.GetInstance<ISiteService>();
            var siteService2 = ObjectFactory.GetInstance<ISiteService>();

            Assert.AreSame(siteService1, siteService2);
        }
    }

}
