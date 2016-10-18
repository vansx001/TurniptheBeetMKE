using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TurnipTheBeetMKE.Startup))]
namespace TurnipTheBeetMKE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
