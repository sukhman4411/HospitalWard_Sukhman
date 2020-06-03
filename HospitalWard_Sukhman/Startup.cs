using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalWard_Sukhman.Startup))]
namespace HospitalWard_Sukhman
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
