using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalProjectv2.Startup))]
namespace PersonalProjectv2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
