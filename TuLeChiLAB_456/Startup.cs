using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TuLeChiLAB_456.Startup))]
namespace TuLeChiLAB_456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
