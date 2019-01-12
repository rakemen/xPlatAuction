using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(xPlatAuction.backend.Startup))]

namespace xPlatAuction.backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}