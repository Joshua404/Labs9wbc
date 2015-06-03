using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movies_HW.Startup))]
namespace Movies_HW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
