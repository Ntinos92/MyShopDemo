using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopDemo.WebUI.Startup))]
namespace MyShopDemo.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
