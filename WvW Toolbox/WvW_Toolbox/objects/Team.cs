using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvW_Toolbox.objects
{
    public class Team
    {
        public string mainWorldID { get; set; }
        public string[] worldIDs { get; set; }
        public string points { get; set; }
        public string kills { get; set; }
        public string deaths { get; set; }

        //Allow for addition of skirmishes in the future

        public Team(string mainWorldID, string[] worldIDs, string points, string kills, string deaths)
        {
            this.mainWorldID = mainWorldID;
            this.worldIDs = worldIDs;
            this.points = points;
            this.kills = kills;
            this.deaths = deaths;
        }

        public Team(int mainWorldID, int[] worldIDs, double points, double kills, double deaths)
        {
            this.mainWorldID = Convert.ToString(mainWorldID);
            this.points = Convert.ToString(points);
            this.kills = Convert.ToString(kills);
            this.deaths = Convert.ToString(deaths);

            for (int i = 0; i < worldIDs.Length; i++)
            {
                this.worldIDs[i] = Convert.ToString(worldIDs[i]);
            }
        }

        public Team(string mainWorldID, int[] worldIDs, string points, string kills, string deaths)
        {
            this.mainWorldID = mainWorldID;
            this.points = points;
            this.kills = kills;
            this.deaths = deaths;

            for (int i = 0; i < worldIDs.Length; i++)
            {
                this.worldIDs[i] = Convert.ToString(worldIDs[i]);
            }
        }

        public Team(int mainWorldID, int[] worldIDs, int points, int kills, int deaths)
        {
            this.mainWorldID = Convert.ToString(mainWorldID);
            this.points = Convert.ToString(points);
            this.kills = Convert.ToString(kills);
            this.deaths = Convert.ToString(deaths);

            for (int i = 0; i < worldIDs.Length; i++)
            {
                this.worldIDs[i] = Convert.ToString(worldIDs[i]);
            }
        }
    }
}
