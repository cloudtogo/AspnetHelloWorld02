using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspnetHelloWorld02.Startup))]
namespace AspnetHelloWorld02
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
