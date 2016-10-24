using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TF_WEB.Startup))]
namespace TF_WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
