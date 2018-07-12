using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllsAleThatEndsAle.Startup))]
namespace AllsAleThatEndsAle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
