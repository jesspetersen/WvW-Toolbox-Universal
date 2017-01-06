using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvW_Toolbox.objects
{
    class Team
    {
        string mainWorldID;
        string[] worldIDs;
        string points;
        string kills;
        string deaths;

        //Allow for addition of skirmishes in the future

        public Team(string mainWorldID, string[] worldIDs, string points, string kills, string deaths)
        {
            this.mainWorldID = mainWorldID;
            this.worldIDs = worldIDs;
            this.points = points;
            this.kills = kills;
            this.deaths = deaths;
        }

    }
}
