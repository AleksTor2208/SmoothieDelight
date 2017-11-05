using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmothieDelight_RecruitmentAssignment.Startup))]
namespace SmothieDelight_RecruitmentAssignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
