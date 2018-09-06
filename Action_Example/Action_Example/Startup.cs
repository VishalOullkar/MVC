using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Action_Example.Startup))]
namespace Action_Example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
