using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirebaseCrudOperations.Startup))]
namespace FirebaseCrudOperations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
