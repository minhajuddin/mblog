using System.Web.Mvc;
using System;
using StructureMap;

namespace MBlog.Web.Miscellaneous {
    public class IoCControllerFactory : DefaultControllerFactory {
        protected override IController GetControllerInstance(Type controllerType) {
            return (Controller)ObjectFactory.GetInstance(controllerType);
        }
    }
}