using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcGuestbook.Startup))]
namespace MvcGuestbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
