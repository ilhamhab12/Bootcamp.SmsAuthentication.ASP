using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmsAndEmailAuthenticationASP.Startup))]
namespace SmsAndEmailAuthenticationASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
