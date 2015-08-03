using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Architecture.Web.Startup))]
namespace Architecture.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
