using Microsoft.AspNet.SignalR;
using ProgressTracking.Modules.SignalR.Model;

namespace ProgressTracking.Modules.SignalR.Hubs
{
    public class ProgressHub : Hub
    {
        public async System.Threading.Tasks.Task Subscribe()
        {
            await Groups.Add(Context.ConnectionId, GetGroup());

            Clients.Client(Context.ConnectionId)
                        .updateProgress(null);
        }

        public static string GetGroup()
        {
            return "ProgressUpdater";
        }
    }
}