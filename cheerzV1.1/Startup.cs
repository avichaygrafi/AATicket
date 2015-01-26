using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cheerzV1._1.Startup))]
namespace cheerzV1._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
