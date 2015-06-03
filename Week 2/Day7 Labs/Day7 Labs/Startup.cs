using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day7_Labs.Startup))]
namespace Day7_Labs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
