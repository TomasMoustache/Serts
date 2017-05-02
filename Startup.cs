using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SERTS.Startup))]
namespace SERTS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
