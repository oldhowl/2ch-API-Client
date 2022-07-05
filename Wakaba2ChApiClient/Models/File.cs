using Newtonsoft.Json;

namespace Wakaba2ChApiClient.Models
{
    public class File
    {

        [JsonProperty("displayname")]
        public string Displayname { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nsfw")]
        public int Nsfw { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("tn_height")]
        public int TnHeight { get; set; }

        [JsonProperty("tn_width")]
        public int TnWidth { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("duration_secs")]
        public int? DurationSecs { get; set; }

        [JsonProperty("install")]
        public string Install { get; set; }

        [JsonProperty("pack")]
        public string Pack { get; set; }

        [JsonProperty("sticker")]
        public string Sticker { get; set; }
    }
}