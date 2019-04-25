using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookExWeb.Startup))]
namespace BookExWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
