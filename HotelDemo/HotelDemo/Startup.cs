using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelDemo.Startup))]
namespace HotelDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
