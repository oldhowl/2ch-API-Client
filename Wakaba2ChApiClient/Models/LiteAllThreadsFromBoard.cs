using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wakaba2ChApiClient.Models
{
    
    public class Thread
    {

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("lasthit")]
        public int Lasthit { get; set; }

        [JsonProperty("num")]
        public string Num { get; set; }

        [JsonProperty("posts_count")]
        public int PostsCount { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }
    }

    public class LiteAllThreadsFromBoard
    {

        [JsonProperty("board")]
        public string Board { get; set; }

        [JsonProperty("threads")]
        public IList<Thread> Threads { get; set; }
    }
    
   
}