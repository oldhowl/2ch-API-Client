using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wakaba2ChApiClient.Models
{
    
    

    public class LiteAllThreadsFromBoard
    {

        [JsonProperty("board")]
        public string Board { get; set; }

        [JsonProperty("threads")]
        public IList<Thread> Threads { get; set; }
    }
    
   
}