using Microsoft.AspNet.SignalR;
using ProgressTracking.Modules.SignalR.Hubs;
using ProgressTracking.Modules.SignalR.Model;

namespace ProgressTracking.Modules.SignalR.Updaters
{
    public class ProgressUpdater
    {
        private readonly IHubContext _hubContext;

        public ProgressUpdater()
        {
            _hubContext = GlobalHost.ConnectionManager.GetHubContext<ProgressHub>();
        }

        public void UpdateProgress(ProgressMessageModel progressModel)
        {
            _hubContext.Clients.Group(ProgressHub.GetGroup()).updateProgress(progressModel);
        }
    }
}