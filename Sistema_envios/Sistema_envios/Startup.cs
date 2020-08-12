using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sistema_envios.Startup))]
namespace Sistema_envios
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
