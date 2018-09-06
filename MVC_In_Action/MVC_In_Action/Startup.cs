using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_In_Action.Startup))]
namespace MVC_In_Action
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
