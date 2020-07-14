using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wakaba2ChApiClient.Models
{
    public class ThreadInfo
    {
        [JsonProperty("files_count")]
        public int FilesCount { get; set; }

        [JsonProperty("posts")]
        public IList<Post> Posts { get; set; }

        [JsonProperty("posts_count")]
        public int PostsCount { get; set; }

        [JsonProperty("thread_num")]
        public string ThreadNum { get; set; }
    }
}