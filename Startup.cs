using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HuynhNhatKhang__Bigschool.Startup))]
namespace HuynhNhatKhang__Bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
