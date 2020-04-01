using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMSMVC.Startup))]
namespace SMSMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
