using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wakaba2ChApiClient.Models.Mobile
{
    public class ThreadOption
    {
        [JsonProperty("bump_limit")] public int BumpLimit { get; set; }

        [JsonProperty("category")] public string Category { get; set; }

        [JsonProperty("default_name")] public string DefaultName { get; set; }

        [JsonProperty("enable_dices")] public int EnableDices { get; set; }

        [JsonProperty("enable_flags")] public int EnableFlags { get; set; }

        [JsonProperty("enable_icons")] public int EnableIcons { get; set; }

        [JsonProperty("enable_likes")] public int EnableLikes { get; set; }

        [JsonProperty("enable_names")] public int EnableNames { get; set; }

        [JsonProperty("enable_oekaki")] public int EnableOekaki { get; set; }

        [JsonProperty("enable_posting")] public int EnablePosting { get; set; }

        [JsonProperty("enable_sage")] public int EnableSage { get; set; }

        [JsonProperty("enable_shield")] public int EnableShield { get; set; }

        [JsonProperty("enable_subject")] public int EnableSubject { get; set; }

        [JsonProperty("enable_thread_tags")] public int EnableThreadTags { get; set; }

        [JsonProperty("enable_trips")] public int EnableTrips { get; set; }

        [JsonProperty("icons")] public IList<object> Icons { get; set; }

        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("pages")] public int Pages { get; set; }

        [JsonProperty("sage")] public int Sage { get; set; }

        [JsonProperty("tripcodes")] public int Tripcodes { get; set; }
    }
}