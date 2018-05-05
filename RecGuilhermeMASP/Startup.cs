using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecGuilhermeMASP.Startup))]
namespace RecGuilhermeMASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
