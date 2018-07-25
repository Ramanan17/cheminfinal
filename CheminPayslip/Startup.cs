using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CheminPayslip.Startup))]
namespace CheminPayslip
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
