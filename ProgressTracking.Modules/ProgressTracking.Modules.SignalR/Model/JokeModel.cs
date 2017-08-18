using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProgressTracking.Modules.SignalR.Model
{
    public class JokeModel
    {
        public int id { get; set; }
        public string joke { get; set; }
    }

    public class JokeList
    {
        public static List<JokeModel> Jokes
        {
            get
            {
                return
                    JsonConvert.DeserializeObject<List<JokeModel>>(
                        "[ { \"id\": 449, \"joke\": \"All arrays Chuck Norris declares are of infinite size, because Chuck Norris knows no bounds.\", \"categories\": [\"nerdy\"] }, { \"id\": 211, \"joke\": \"Nothing can escape the gravity of a black hole, except for Chuck Norris. Chuck Norris eats black holes. They taste like chicken.\", \"categories\": [] }, { \"id\": 331, \"joke\": \"Chuck Norris once ate four 30lb bowling balls without chewing.\", \"categories\": [] }, { \"id\": 603, \"joke\": \"Ghosts are actually caused by Chuck Norris killing people faster than Death can process them.\", \"categories\": [] }, { \"id\": 65, \"joke\": \"When Chuck Norris was denied an Egg McMuffin at McDonald's because it was 10:35, he roundhouse kicked the store so hard it became a Wendy's.\", \"categories\": [] }, { \"id\": 156, \"joke\": \"There is no such thing as global warming. Chuck Norris was cold, so he turned the sun up.\", \"categories\": [] }, { \"id\": 426, \"joke\": \"A man once taunted Chuck Norris with a bag of Lay's potato chips, saying &quot;Betcha can't eat just one!&quot; Chuck Norris proceeded to eat the chips, the bag, and the man in one deft move.\", \"categories\": [] }, { \"id\": 154, \"joke\": \"Movie trivia: The movie &quot;Invasion U.S.A.&quot; is, in fact, a documentary.\", \"categories\": [] }, { \"id\": 434, \"joke\": \"Chuck Norris wipes his butt with chain mail and sandpaper.\", \"categories\": [] }, { \"id\": 158, \"joke\": \"It's widely believed that Jesus was Chuck Norris' stunt double for crucifixion due to the fact that it is impossible for nails to pierce Chuck Norris' skin.\", \"categories\": [] }, { \"id\": 23, \"joke\": \"Time waits for no man. Unless that man is Chuck Norris.\", \"categories\": [] }, { \"id\": 592, \"joke\": \"Chuck Norris can make onions cry.\", \"categories\": [] }, { \"id\": 314, \"joke\": \"July 4th is Independence day. And the day Chuck Norris was born. Coincidence? I think not.\", \"categories\": [] }, { \"id\": 345, \"joke\": \"When in a bar, you can order a drink called a &quot;Chuck Norris&quot;. It is also known as a &quot;Bloody Mary&quot;, if your name happens to be Mary.\", \"categories\": [] }, { \"id\": 427, \"joke\": \"Chuck Norris' favorite cereal is Kellogg's Nails 'N' Gravel.\", \"categories\": [] }, { \"id\": 301, \"joke\": \"The First Law of Thermodynamics states that energy can neither be created nor destroyed... unless it meets Chuck Norris.\", \"categories\": [] }, { \"id\": 268, \"joke\": \"He who lives by the sword, dies by the sword. He who lives by Chuck Norris, dies by the roundhouse kick.\", \"categories\": [] }, { \"id\": 489, \"joke\": \"Chuck Norris can write multi-threaded applications with a single thread.\", \"categories\": [\"nerdy\"] }, { \"id\": 593, \"joke\": \"Chuck Norris can watch the radio.\", \"categories\": [] }, { \"id\": 313, \"joke\": \"All roads lead to Chuck Norris. And by the transitive property, a roundhouse kick to the face.\", \"categories\": [] }, { \"id\": 222, \"joke\": \"Industrial logging isn't the cause of deforestation. Chuck Norris needs toothpicks.\", \"categories\": [] }, { \"id\": 14, \"joke\": \"There are no steroids in baseball. Just players Chuck Norris has breathed on.\", \"categories\": [] }]");
            }
        }
    }
}