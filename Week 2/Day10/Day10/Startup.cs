using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day10.Startup))]
namespace Day10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
