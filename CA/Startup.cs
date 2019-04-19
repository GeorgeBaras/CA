using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CA.Startup))]
namespace CA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
