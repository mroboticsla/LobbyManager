using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LobbyManager.Startup))]
namespace LobbyManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
