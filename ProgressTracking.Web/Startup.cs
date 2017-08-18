using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using Umbraco.Web;

[assembly: OwinStartupAttribute(typeof(ProgressTracking.Web.Startup))]
namespace ProgressTracking.Web
{
    public partial class Startup : UmbracoDefaultOwinStartup
    {
        public override void Configuration(IAppBuilder app)
        {
            app.MapSignalR("/signalr", new HubConfiguration());

            base.Configuration(app);
        }
    }
}
