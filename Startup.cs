using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Beta.Startup))]
namespace Beta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
