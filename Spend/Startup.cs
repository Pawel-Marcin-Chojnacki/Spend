using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Spend.Startup))]
namespace Spend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
