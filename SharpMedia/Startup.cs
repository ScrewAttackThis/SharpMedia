using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SharpMedia.Startup))]
namespace SharpMedia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
