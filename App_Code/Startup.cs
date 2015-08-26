using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SECUDEVCase1_Site.Startup))]
namespace SECUDEVCase1_Site
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
