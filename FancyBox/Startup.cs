using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FancyBox.Startup))]
namespace FancyBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
