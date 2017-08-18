using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading;
using Newtonsoft.Json;
using ProgressTracking.Modules.SignalR.Model;
using ProgressTracking.Modules.SignalR.Updaters;

namespace ProgressTracking.Modules.SignalR.Services
{
    public class MyCustomService
    {
        private static int _jokeCounter = 0;
        public static void InitiateProgressTest()
        {
            var updater = new ProgressUpdater();
            var total = 1000;
            var jokeList = JokeList.Jokes;

            for (var i = 0; i <= total; i++)
            {
                int percentComplete = (int)(0.5f + ((100f * i) / total));

                var joke = string.Empty;

                if (i%50 == 0 || i == 0)
                {
                    joke = jokeList.ElementAt(_jokeCounter).joke;
                    _jokeCounter++;
                }

                updater.UpdateProgress(new ProgressMessageModel
                {
                    IsComplete = i == 1000,
                    Message = "Processing " + i + " of " + total + " records",
                    PercentComplete = percentComplete,
                    Joke = joke
                });

                Thread.Sleep(125);
            }
        }
    }
}