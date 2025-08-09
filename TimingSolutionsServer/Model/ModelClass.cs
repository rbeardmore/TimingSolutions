using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimingSolutionsServer.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Timing
    {
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
        [JsonProperty("series")]
        public string Series { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("track")]
        public string Track { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("startTime")]
        public DateTime StartTime { get; set; }
        [JsonProperty("duration")]
        public string Duration { get; set; }
        [JsonProperty("competitors")]
        public List<Competitor> Competitors { get; set; }
        [JsonProperty("timeRemaining")]
        public string TimeRemaining { get; set; }

    }
    public class Competitor
    {
        public string Id { get; set; }

        [JsonProperty("startNumber")]
        public string StartNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }
    }

    public class FastestLapTime
    {
        [JsonProperty("display")]
        public string Display { get; set; }

        [JsonProperty("rawMs")]
        public int RawMs { get; set; }
    }

    public class LastLapTime
    {
        [JsonProperty("display")]
        public string Display { get; set; }

        [JsonProperty("rawMs")]
        public int RawMs { get; set; }
    }

    public class Result
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("laps")]
        public int Laps { get; set; }

        [JsonProperty("fastestLapTime")]
        public FastestLapTime FastestLapTime { get; set; }

        [JsonProperty("lastLapTime")]
        public LastLapTime LastLapTime { get; set; }
    }
}
