using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WvW_Toolbox.utilities
{
    class WorldSearchHelper
    {

        public static List<objects.World> ListAllWorlds()
        {

            List<objects.World> worldList = new List<objects.World>();

            foreach (JsonWorldObject j in JsonConvert.DeserializeObject<List<JsonWorldObject>>(Properties.Resources.AllWorldsJson))
            {
                objects.World w = new objects.World(j.id, j.name, j.population);
                worldList.Add(w);
            }

            return worldList;
        }

        public static objects.World FindWorldById(int id)
        {
            List<objects.World> worlds = ListAllWorlds();
            objects.World placeholderWorld = new objects.World("", "", "");
            foreach (objects.World w in worlds)
            {
                if (w.id == Convert.ToString(id))
                {
                    return w;
                }
            }

            return placeholderWorld;
        }
    }

    //Helpers for deserializing world list
    public class JsonWorld
    {
        [JsonProperty("")]
        public JsonWorldObject jsonWorldObject { get; set; }
    }

    public class JsonWorldObject
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("population")]
        public string population { get; set; }
    }
}
