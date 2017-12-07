using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(scoreboardVB10.Startup))]
namespace scoreboardVB10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
