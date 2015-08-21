using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimplyRating.Startup))]
namespace SimplyRating
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
