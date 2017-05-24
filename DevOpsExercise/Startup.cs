using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOpsExercise.Startup))]
namespace DevOpsExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
