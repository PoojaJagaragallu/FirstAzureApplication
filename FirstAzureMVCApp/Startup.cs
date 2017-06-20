using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstAzureMVCApp.Startup))]
namespace FirstAzureMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
