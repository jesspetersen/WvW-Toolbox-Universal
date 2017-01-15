using Android.Util;
using Newtonsoft.Json;
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

        //Method to search keeps that belong to each server
        //Return multidimensional array or list of lists

        public static List<List<objects.Objective>> SortObjectivesByMap()
        {
            List<objects.Objective> redHome = new List<objects.Objective>();
            List<objects.Objective> greenHome = new List<objects.Objective>();
            List<objects.Objective> blueHome = new List<objects.Objective>();
            List<objects.Objective> EBG = new List<objects.Objective>();

            foreach (JsonObjective j in JsonConvert.DeserializeObject<List<JsonObjective>>(Properties.Resources.AllObjectivesJson))
            {
                objects.Objective g = Global.allObjectives.Single(x => Convert.ToInt32(x.id) == Convert.ToInt32(j.id));
                objects.Objective o = new objects.Objective(j.id, j.type, g.owner);

                if (j.mapType == "RedHome")
                    redHome.Add(o);
                else if (j.mapType == "BlueHome")
                    blueHome.Add(o);
                else if (j.mapType == "GreenHome")
                    greenHome.Add(o);
                else if (j.mapType == "Center")
                    EBG.Add(o);
            }

            List<List<objects.Objective>> mapsOfObjectives = new List<List<objects.Objective>>();
            mapsOfObjectives.Add(redHome);
            mapsOfObjectives.Add(greenHome);
            mapsOfObjectives.Add(blueHome);
            mapsOfObjectives.Add(EBG);

            return mapsOfObjectives;
        }

        //Helpers for deserializing objectives

        public class JsonObjective
        {
            [JsonProperty("id")]
            public string id { get; set; }

            [JsonProperty("name")]
            public string name { get; set; }

            [JsonProperty("sector_id")]
            public string sectorID { get; set; }

            [JsonProperty("type")]
            public string type { get; set; }

            [JsonProperty("map_type")]
            public string mapType { get; set; }

            [JsonProperty("map_id")]
            public string mapID { get; set; }

            [JsonProperty("coord")]
            public string[] coord { get; set; }

            [JsonProperty("label_coord")]
            public string[] labelCoord { get; set; }

            [JsonProperty("marker")]
            public string marker { get; set; }

            [JsonProperty("chat_link")]
            public string chatLink { get; set; }
        }
    }
}
