using System;
using System.IO;

namespace rockstar_webapi
{
    public class Music
    {
        public string SleepOnTheFloor { get; set; }

        public string GirlsLikeYou { get; set; }

        public Music()
        {
            if(File.Exists("SleepOnTheFloor.txt"))
            {
                SleepOnTheFloor = File.ReadAllText("SleepOnTheFloor.txt");
            }
            else
            {
                SleepOnTheFloor = "??";
            }
            if (File.Exists("GirlsLikeYou.txt"))
            {
                GirlsLikeYou = File.ReadAllText("GirlsLikeYou.txt");
            }
            else
            {
                GirlsLikeYou = "??";
            }
        }
    }
}