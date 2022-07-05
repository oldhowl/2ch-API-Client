using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wakaba2ChApiClient.Models
{
   // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class ThreadResultFile
    {
        [JsonProperty("displayname")]
        public string Displayname { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("duration_secs")]
        public int DurationSecs { get; set; }

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
    }

    public class ThreadPost
    {
        [JsonProperty("banned")]
        public int Banned { get; set; }

        [JsonProperty("closed")]
        public int Closed { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("endless")]
        public int Endless { get; set; }

        [JsonProperty("files")]
        public List<ThreadResultFile> Files { get; set; }

        [JsonProperty("lasthit")]
        public int Lasthit { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num")]
        public string Num { get; set; }

        [JsonProperty("op")]
        public int Op { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("sticky")]
        public int Sticky { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("trip")]
        public string Trip { get; set; }

        [JsonProperty("trip_type")]
        public string TripType { get; set; }

        [JsonProperty("unique_posters")]
        public string UniquePosters { get; set; }
    }


}