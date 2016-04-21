using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GTCorp.Startup))]
namespace GTCorp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
