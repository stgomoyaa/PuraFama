using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PuraFama.Startup))]
namespace PuraFama
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
