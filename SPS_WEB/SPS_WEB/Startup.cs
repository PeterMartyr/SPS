using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SPS_WEB.Startup))]
namespace SPS_WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
