using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GribApiAspNet.Startup))]
namespace GribApiAspNet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
