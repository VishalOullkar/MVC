using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_App_Using_Entity_Framework.Startup))]
namespace MVC_App_Using_Entity_Framework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
