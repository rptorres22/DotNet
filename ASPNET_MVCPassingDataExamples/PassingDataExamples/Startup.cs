using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PassingDataExamples.Startup))]
namespace PassingDataExamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
