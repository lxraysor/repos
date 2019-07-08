using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaysorConsulting.Startup))]
namespace RaysorConsulting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
