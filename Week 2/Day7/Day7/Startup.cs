using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day7.Startup))]
namespace Day7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
