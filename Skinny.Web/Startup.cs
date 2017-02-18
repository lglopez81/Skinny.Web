using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Skinny.Web.Startup))]
namespace Skinny.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
