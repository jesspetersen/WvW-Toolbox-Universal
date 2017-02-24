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

        public static void SortObjectivesByMap()
        {
            //List<objects.Objective> redHome = new List<objects.Objective>();
            //List<objects.Objective> greenHome = new List<objects.Objective>();
            //List<objects.Objective> blueHome = new List<objects.Objective>();
            //List<objects.Objective> EBG = new List<objects.Objective>();

            foreach (JsonObjective j in JsonConvert.DeserializeObject<List<JsonObjective>>(Properties.Resources.AllObjectivesJson))
            {
                try
                {
                    objects.Objective g = Global.allObjectives.Single(x => x.id == j.id);

                    if (j.mapID == 1099 || j.mapID == 94)
                    {
                        //redHome.Add(g);
                        g.map = "Red BL";
                        g.mapColour = "#ff0000";
                    }
                    else if (j.mapID == 1143 || j.mapID == 96)
                    {
                        //blueHome.Add(g);
                        g.map = "Blue BL";
                        g.mapColour = "#0000ff";
                    }
                    else if (j.mapID == 1102 || j.mapID == 95)
                    {
                        //greenHome.Add(g);
                        g.map = "Green BL";
                        g.mapColour = "#008000";
                    }
                    else if (j.mapID == 38)
                    {
                        //EBG.Add(g);
                        g.map = "EBG";
                        g.mapColour = "#565656";
                    }
                }
                catch { }
            }

            //List<List<objects.Objective>> mapsOfObjectives = new List<List<objects.Objective>>();
            //mapsOfObjectives.Add(redHome);
            //mapsOfObjectives.Add(greenHome);
            //mapsOfObjectives.Add(blueHome);
            //mapsOfObjectives.Add(EBG);

            //NameObjectives(mapsOfObjectives);

            //return mapsOfObjectives;
        }

        public static void NameObjectives(List<List<objects.Objective>> maps)
        {
            //first sort by map
            foreach (List<objects.Objective> objectives in maps)
            {
                //ebg
                if (objectives.First().id.Contains("38"))
                {
                    //Set objective names
                    foreach (objects.Objective o in objectives)
                    {
                        if (o.id == "38-11")
                            o.name = "Aldon's";

                        if (o.id == "38-1")
                            o.name = "Red Keep";

                        if (o.id == "38-15")
                            o.name = "Langor";

                        if (o.id == "38-3")
                            o.name = "Green Keep";

                        if (o.id == "38-17")
                            o.name = "Mendon's";

                        if (o.id == "38-7")
                            o.name = "Danelon";

                        if (o.id == "38-9")
                            o.name = "SMC";

                        if (o.id == "38-5")
                            o.name = "Pangloss";

                        if (o.id == "38-21")
                            o.name = "Durios";

                        if (o.id == "38-20")
                            o.name = "Veloka";

                        if (o.id == "38-14")
                            o.name = "Klovan";

                        if (o.id == "38-13")
                            o.name = "Jerrifer's";

                        if (o.id == "38-6")
                            o.name = "Speldan";

                        if (o.id == "38-2")
                            o.name = "Blue Keep";

                        if (o.id == "38-12")
                            o.name = "Wildcreek";

                        if (o.id == "38-16")
                            o.name = "Quentin";

                        if (o.id == "38-22")
                            o.name = "Bravost";

                        if (o.id == "38-19")
                            o.name = "Ogrewatch";

                        if (o.id == "38-4")
                            o.name = "Golanta";

                        if (o.id == "38-8")
                            o.name = "Umberglade";

                        if (o.id == "38-10")
                            o.name = "Rogue's";

                        if (o.id == "38-18")
                            o.name = "Anzalias";
                    }
                }

                //if is a DBL
                if (objectives.First().id.Contains("1099") || objectives.First().id.Contains("1143") || objectives.First().id.Contains("1102"))
                {

                    //Set BL name
                    foreach (objects.Objective o in objectives)
                    {
                        //red dbl
                        if (o.id.Contains("1099"))
                            o.name = "RBL-";

                        //blue dbl
                        if (o.id.Contains("1143"))
                            o.name = "BBL-";

                        //green dbl
                        if (o.id.Contains("1102"))
                            o.name = "GBL-";
                    }

                    //Set objective identifier
                    foreach (objects.Objective o in objectives)
                    {
                        if (o.id == "99")
                            o.name += "NC";

                        if (o.id == "100")
                            o.name += "SEC";

                        if (o.id == "101")
                            o.name += "SWC";

                        if (o.id == "102")
                            o.name += "NWT";

                        if (o.id == "104")
                            o.name += "NET";

                        if (o.id == "105")
                            o.name += "SET";

                        if (o.id == "106")
                            o.name += "FIRE";

                        if (o.id == "109")
                            o.name += "NEC";

                        if (o.id == "110")
                            o.name += "SWT";

                        if (o.id == "113")
                            o.name += "GARRI";

                        if (o.id == "114")
                            o.name += "AIR";

                        if (o.id == "115")
                            o.name += "NWC";

                        if (o.id == "116")
                            o.name += "SC";
                    }

                }

                //If this is an ABL
                if (objectives.First().id.Contains("94") || objectives.First().id.Contains("96") || objectives.First().id.Contains("95"))
                {

                    //Set BL name
                    foreach (objects.Objective o in objectives)
                    {
                        //red dbl
                        if (o.id.Contains("94"))
                            o.name = "RBL-";

                        //blue dbl
                        if (o.id.Contains("96"))
                            o.name = "BBL-";

                        //green dbl
                        if (o.id.Contains("95"))
                            o.name = "GBL-";
                    }

                    //Set objective identifier
                    foreach (objects.Objective o in objectives)
                    {
                        if (o.id == "35")
                            o.name += "SWT";

                        if (o.id == "32")
                            o.name += "HILLS";

                        if (o.id == "33")
                            o.name += "BAY";

                        if (o.id == "38")
                            o.name += "NWT";

                        if (o.id == "39")
                            o.name += "NC";

                        if (o.id == "37")
                            o.name += "GARRI";

                        if (o.id == "53")
                            o.name += "SWC";

                        if (o.id == "52")
                            o.name += "NWC";

                        if (o.id == "51")
                            o.name += "NEC";

                        if (o.id == "34")
                            o.name += "SC";

                        if (o.id == "36")
                            o.name += "SET";

                        if (o.id == "50")
                            o.name += "SEC";

                        if (o.id == "40")
                            o.name += "NET";
                    }
                }
            }
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
            public int mapID { get; set; }

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
