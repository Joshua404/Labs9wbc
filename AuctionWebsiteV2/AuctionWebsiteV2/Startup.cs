using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuctionWebsiteV2.Startup))]
namespace AuctionWebsiteV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
