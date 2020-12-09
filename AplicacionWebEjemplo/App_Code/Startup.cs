using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplicacionWebEjemplo.Startup))]
namespace AplicacionWebEjemplo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
