namespace ProgressTracking.Modules.SignalR.Model
{
    public class ProgressMessageModel
    {
        public string Message { get; set; }
        public string Joke { get; set; }
        public int PercentComplete { get; set; }
        public bool IsComplete { get; set; }
    }
}