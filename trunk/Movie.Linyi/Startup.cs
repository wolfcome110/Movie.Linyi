using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movie.Linyi.Startup))]
namespace Movie.Linyi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
