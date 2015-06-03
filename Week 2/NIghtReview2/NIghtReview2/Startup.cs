using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NIghtReview2.Startup))]
namespace NIghtReview2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
