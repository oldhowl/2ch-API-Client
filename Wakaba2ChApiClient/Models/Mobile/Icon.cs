using Newtonsoft.Json;

namespace Wakaba2ChApiClient.Models.Mobile
{
    public class Icon
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}