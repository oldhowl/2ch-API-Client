using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wakaba2ChApiClient.Models
{
    public class Post
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
        public IList<File> Files { get; set; }

        [JsonProperty("files_count")]
        public int FilesCount { get; set; }

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

        [JsonProperty("posts_count")]
        public int PostsCount { get; set; }

        [JsonProperty("sticky")]
        public int Sticky { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("trip")]
        public string Trip { get; set; }
    }
}