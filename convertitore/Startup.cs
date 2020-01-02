using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(convertitore.Startup))]
namespace convertitore
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
