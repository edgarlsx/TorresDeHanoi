using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TorresDeHanoiApp.Startup))]
namespace TorresDeHanoiApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
