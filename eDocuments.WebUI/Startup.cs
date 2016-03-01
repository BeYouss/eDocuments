using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eDocuments.WebUI.Startup))]
namespace eDocuments.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
