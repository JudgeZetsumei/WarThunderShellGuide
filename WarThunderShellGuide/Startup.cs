using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WarThunderShellGuide.Startup))]
namespace WarThunderShellGuide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
