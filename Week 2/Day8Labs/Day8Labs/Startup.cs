using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day8Labs.Startup))]
namespace Day8Labs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
