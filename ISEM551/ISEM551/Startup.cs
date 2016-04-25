using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISEM551.Startup))]
namespace ISEM551
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
