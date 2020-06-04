using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_HoKimLong.Startup))]
namespace Lab3_HoKimLong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
