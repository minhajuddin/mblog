using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Attributes;
using MBlog.Core.Domain.DataAccess;
using MBlog.Core.Services;
using MBlog.Core.DataAccess;

namespace MBlog.Web.BootStrap {
    public class BootStrapper {
        public static void ConfigureStructureMap() {
            StructureMapConfiguration.AddRegistry(new MBlogRegistry());
        }

        private class MBlogRegistry : Registry {
            protected override void configure() {
                //Configure structure map to return proper instance types
                //Data stuff
                StructureMapConfiguration.ForRequestedType<IPostRepository>()
                    .TheDefaultIsConcreteType<PostRepository>();
                StructureMapConfiguration.ForRequestedType<ISiteRepository>()
                    .TheDefaultIsConcreteType<SiteRepository>();



                //Services stuff
                StructureMapConfiguration.ForRequestedType<IPostService>()
                    .TheDefaultIsConcreteType<PostService>();
                StructureMapConfiguration.ForRequestedType<ISiteService>()
                    .TheDefaultIsConcreteType<SiteService>()
                    .AsSingletons();
            }
        }
    }
}
