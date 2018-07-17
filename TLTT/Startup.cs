using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TLTT.Startup))]
namespace TLTT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
