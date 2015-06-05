using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day9.Startup))]
namespace Day9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
