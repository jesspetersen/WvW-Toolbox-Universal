using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WvW_Toolbox.utilities
{
    class MatchHelper
    {
        private const string Url = "https://api.guildwars2.com/v2/wvw/matches/stats?world=";

        public static async void GetAsyncContent()
        {
            HttpClient myClient = new HttpClient();
            var content = await myClient.GetStringAsync(Url + Xamarin.Forms.Application.Current.Properties["Server"].ToString());
            var match = JsonConvert.DeserializeObject<JsonMatch>(content);
        }
    }

    public class JsonMatch
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("start_time")]
        public string start_time { get; set; }

        [JsonProperty("end_time")]
        public string end_time { get; set; }

        [JsonProperty("scores")]
        public JsonScores scores { get; set; }

        [JsonProperty("worlds")]
        public JsonWorlds worlds { get; set; }

        [JsonProperty("all_worlds")]
        public JsonAllWorlds all_worlds { get; set; }

        [JsonProperty("deaths")]
        public JsonDeaths deaths { get; set; }

        [JsonProperty("kills")]
        public JsonKills kills { get; set; }

        [JsonProperty("maps")]
        public string maps { get; set; }
    }

    public class JsonScores
    {
        [JsonProperty("red")]
        public int red { get; set; }

        [JsonProperty("blue")]
        public int blue { get; set; }

        [JsonProperty("green")]
        public int green { get; set; }
    }

    public class JsonWorlds
    {
        [JsonProperty("red")]
        public int red { get; set; }

        [JsonProperty("blue")]
        public int blue { get; set; }

        [JsonProperty("green")]
        public int green { get; set; }
    }

    public class JsonAllWorlds
    {
        [JsonProperty("red")]
        public int[] red { get; set; }

        [JsonProperty("blue")]
        public int[] blue { get; set; }

        [JsonProperty("green")]
        public int[] green { get; set; }
    }

    public class JsonDeaths
    {
        [JsonProperty("red")]
        public double red { get; set; }

        [JsonProperty("blue")]
        public double blue { get; set; }

        [JsonProperty("green")]
        public double green { get; set; }
    }

    public class JsonKills
    {
        [JsonProperty("red")]
        public double red { get; set; }

        [JsonProperty("blue")]
        public double blue { get; set; }

        [JsonProperty("green")]
        public double green { get; set; }
    }
}
