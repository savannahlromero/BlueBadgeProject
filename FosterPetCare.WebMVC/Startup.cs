using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FosterPetCare.WebMVC.Startup))]
namespace FosterPetCare.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
