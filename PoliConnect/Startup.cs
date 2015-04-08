using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoliConnect.Startup))]
namespace PoliConnect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
