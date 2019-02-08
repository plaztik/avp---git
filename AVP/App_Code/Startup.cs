using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AVP.Startup))]
namespace AVP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
