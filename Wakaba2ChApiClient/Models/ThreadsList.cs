using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wakaba2ChApiClient.Models
{
    public class ThreadsList
    {
        [JsonProperty("Board")] public string Board { get; set; }

        [JsonProperty("BoardInfo")] public string BoardInfo { get; set; }

        [JsonProperty("BoardInfoOuter")] public string BoardInfoOuter { get; set; }

        [JsonProperty("BoardName")] public string BoardName { get; set; }

        [JsonProperty("advert_bottom_image")] public string AdvertBottomImage { get; set; }

        [JsonProperty("advert_bottom_link")] public string AdvertBottomLink { get; set; }

        [JsonProperty("advert_mobile_image")] public string AdvertMobileImage { get; set; }

        [JsonProperty("advert_mobile_link")] public string AdvertMobileLink { get; set; }

        [JsonProperty("advert_top_image")] public string AdvertTopImage { get; set; }

        [JsonProperty("advert_top_link")] public string AdvertTopLink { get; set; }

        [JsonProperty("board_banner_image")] public string BoardBannerImage { get; set; }

        [JsonProperty("board_banner_link")] public string BoardBannerLink { get; set; }

        [JsonProperty("board_speed")] public int BoardSpeed { get; set; }

        [JsonProperty("bump_limit")] public int BumpLimit { get; set; }

        [JsonProperty("current_page")] public int CurrentPage { get; set; }

        [JsonProperty("current_thread")] public int CurrentThread { get; set; }

        [JsonProperty("default_name")] public string DefaultName { get; set; }

        [JsonProperty("enable_dices")] public int EnableDices { get; set; }

        [JsonProperty("enable_flags")] public int EnableFlags { get; set; }

        [JsonProperty("enable_icons")] public int EnableIcons { get; set; }

        [JsonProperty("enable_images")] public int EnableImages { get; set; }

        [JsonProperty("enable_likes")] public int EnableLikes { get; set; }

        [JsonProperty("enable_names")] public int EnableNames { get; set; }

        [JsonProperty("enable_oekaki")] public int EnableOekaki { get; set; }

        [JsonProperty("enable_posting")] public int EnablePosting { get; set; }

        [JsonProperty("enable_sage")] public int EnableSage { get; set; }

        [JsonProperty("enable_shield")] public int EnableShield { get; set; }

        [JsonProperty("enable_subject")] public int EnableSubject { get; set; }

        [JsonProperty("enable_thread_tags")] public int EnableThreadTags { get; set; }

        [JsonProperty("enable_trips")] public int EnableTrips { get; set; }

        [JsonProperty("enable_video")] public int EnableVideo { get; set; }

        [JsonProperty("is_board")] public int IsBoard { get; set; }

        [JsonProperty("is_index")] public int IsIndex { get; set; }

        [JsonProperty("max_comment")] public int MaxComment { get; set; }

        [JsonProperty("max_files_size")] public int MaxFilesSize { get; set; }

        [JsonProperty("news_abu")] public IList<NewsAbu> NewsAbu { get; set; }

        [JsonProperty("pages")] public IList<int> Pages { get; set; }

        [JsonProperty("threads")] public IList<Thread> Threads { get; set; }

        [JsonProperty("top")] public IList<Top> Top { get; set; }
    }
}