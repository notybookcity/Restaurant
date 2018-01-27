using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restaurant.UI.Startup))]
namespace Restaurant.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
