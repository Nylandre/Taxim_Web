using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Taxim.Startup))]
namespace Taxim
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
