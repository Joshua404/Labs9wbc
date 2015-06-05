using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_5wy4whshw45s.Startup))]
namespace _5wy4whshw45s
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
