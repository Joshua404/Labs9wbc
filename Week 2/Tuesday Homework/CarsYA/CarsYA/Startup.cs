using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarsYA.Startup))]
namespace CarsYA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
