using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Model_Design.Startup))]
namespace Model_Design
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
