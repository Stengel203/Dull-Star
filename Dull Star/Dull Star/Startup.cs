using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dull_Star.Startup))]
namespace Dull_Star
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
