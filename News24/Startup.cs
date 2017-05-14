using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(News24.Startup))]
namespace News24
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
