using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NoLogoStudio_CRUD.Presentation.Startup))]
namespace NoLogoStudio_CRUD.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
