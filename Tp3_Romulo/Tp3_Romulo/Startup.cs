using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tp3_Romulo.Startup))]
namespace Tp3_Romulo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
