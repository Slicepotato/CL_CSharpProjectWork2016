using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Manticore.Startup))]
namespace Manticore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
