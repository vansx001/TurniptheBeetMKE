using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TurniptheBeetMKE.Startup))]
namespace TurniptheBeetMKE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
