using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebSite_Schreinerei.Startup))]
namespace TestWebSite_Schreinerei
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
