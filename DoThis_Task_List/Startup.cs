using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoThis_Task_List.Startup))]
namespace DoThis_Task_List
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
