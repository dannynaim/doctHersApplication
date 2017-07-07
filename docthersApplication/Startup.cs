using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(docthersApplication.Startup))]
namespace docthersApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
