using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookExchange.Startup))]
namespace BookExchange
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
