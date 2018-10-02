using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VN.Startup))]
namespace VN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
