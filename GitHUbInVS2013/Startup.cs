using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHUbInVS2013.Startup))]
namespace GitHUbInVS2013
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
