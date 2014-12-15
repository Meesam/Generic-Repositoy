using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGenericRepositoryPettern.Startup))]
namespace MVCGenericRepositoryPettern
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
