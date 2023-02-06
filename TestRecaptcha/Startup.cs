using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestRecaptcha.Startup))]
namespace TestRecaptcha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
