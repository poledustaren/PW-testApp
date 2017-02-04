using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParrotWingsTestApplication.Startup))]
namespace ParrotWingsTestApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
