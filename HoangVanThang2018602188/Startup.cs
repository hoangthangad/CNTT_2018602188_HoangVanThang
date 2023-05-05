using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoangVanThang2018602188.Startup))]
namespace HoangVanThang2018602188
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
