using Android.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvW_Toolbox.utilities
{
    class ObjectiveSorter
    {
        public static int[] SortObjectivesForCount()
        {
            int[] objectiveCount = new int[12];

            //Allocate objectiveCount[0] to red castles, [1] to red keeps, [2] to red towers, [3] to red camps
            //Allocate objectiveCount[4] to green castles, [5] to green keeps, [6] to green towers, [7] to green camps
            //Allocate objectiveCount[8] to blue castles, [9] to blue keeps, [10] to blue towers, [11] to blue camps

            foreach (objects.Objective o in Global.allObjectives)
            {
                if (o.owner == "Red")
                {
                    if (o.type == "Castle")
                        objectiveCount[0]++;
                    if (o.type == "Keep")
                        objectiveCount[1]++;
                    if (o.type == "Tower")
                        objectiveCount[2]++;
                    if (o.type == "Camp")
                        objectiveCount[3]++;
                }

                if (o.owner == "Green")
                {
                    if (o.type == "Castle")
                        objectiveCount[4]++;
                    if (o.type == "Keep")
                        objectiveCount[5]++;
                    if (o.type == "Tower")
                        objectiveCount[6]++;
                    if (o.type == "Camp")
                        objectiveCount[7]++;
                }

                if (o.owner == "Blue")
                {
                    if (o.type == "Castle")
                        objectiveCount[8]++;
                    if (o.type == "Keep")
                        objectiveCount[9]++;
                    if (o.type == "Tower")
                        objectiveCount[10]++;
                    if (o.type == "Camp")
                        objectiveCount[11]++;
                }
            }

            return objectiveCount;
        }
    }
}
