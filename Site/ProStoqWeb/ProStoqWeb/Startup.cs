using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProStoqWeb.Startup))]
namespace ProStoqWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
