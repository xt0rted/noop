[assembly: Microsoft.Owin.OwinStartup(typeof(Website.Startup))]
namespace Website
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}
