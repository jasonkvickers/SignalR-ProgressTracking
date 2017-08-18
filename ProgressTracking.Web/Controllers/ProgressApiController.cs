using System.Web.Http;
using ProgressTracking.Modules.SignalR.Services;
using Umbraco.Web.WebApi;

namespace ProgressTracking.Web.Controllers
{
    public class ProgressApiController : UmbracoApiController
    {
        [HttpPost]
        public void InitProgress()
        {
            MyCustomService.InitiateProgressTest();
        }
    }
}