using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(exploreRazor.Startup))]
namespace exploreRazor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
