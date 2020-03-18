using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeliveryServiceManagementSystem.Startup))]
namespace DeliveryServiceManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
