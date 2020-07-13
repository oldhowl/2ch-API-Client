using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wakaba2ChApiClient.Models
{
        public class NewsAbu
    {

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }
    }

    public class File
    {

        [JsonProperty("displayname")]
        public string Displayname { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nsfw")]
        public int Nsfw { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("tn_height")]
        public int TnHeight { get; set; }

        [JsonProperty("tn_width")]
        public int TnWidth { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("duration_secs")]
        public int? DurationSecs { get; set; }

        [JsonProperty("install")]
        public string Install { get; set; }

        [JsonProperty("pack")]
        public string Pack { get; set; }

        [JsonProperty("sticker")]
        public string Sticker { get; set; }
    }

    public class ThreadFull
    {

        [JsonProperty("banned")]
        public int Banned { get; set; }

        [JsonProperty("closed")]
        public int Closed { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("endless")]
        public int Endless { get; set; }

        [JsonProperty("files")]
        public IList<File> Files { get; set; }

        [JsonProperty("files_count")]
        public int FilesCount { get; set; }

        [JsonProperty("lasthit")]
        public int Lasthit { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num")]
        public string Num { get; set; }

        [JsonProperty("op")]
        public int Op { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("posts_count")]
        public int PostsCount { get; set; }

        [JsonProperty("sticky")]
        public int Sticky { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("trip")]
        public string Trip { get; set; }
    }

    public class Top
    {

        [JsonProperty("board")]
        public string Board { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AllThreads
    {

        [JsonProperty("Board")]
        public string Board { get; set; }

        [JsonProperty("BoardInfo")]
        public string BoardInfo { get; set; }

        [JsonProperty("BoardInfoOuter")]
        public string BoardInfoOuter { get; set; }

        [JsonProperty("BoardName")]
        public string BoardName { get; set; }

        [JsonProperty("advert_bottom_image")]
        public string AdvertBottomImage { get; set; }

        [JsonProperty("advert_bottom_link")]
        public string AdvertBottomLink { get; set; }

        [JsonProperty("advert_mobile_image")]
        public string AdvertMobileImage { get; set; }

        [JsonProperty("advert_mobile_link")]
        public string AdvertMobileLink { get; set; }

        [JsonProperty("advert_top_image")]
        public string AdvertTopImage { get; set; }

        [JsonProperty("advert_top_link")]
        public string AdvertTopLink { get; set; }

        [JsonProperty("board_banner_image")]
        public string BoardBannerImage { get; set; }

        [JsonProperty("board_banner_link")]
        public string BoardBannerLink { get; set; }

        [JsonProperty("bump_limit")]
        public int BumpLimit { get; set; }

        [JsonProperty("default_name")]
        public string DefaultName { get; set; }

        [JsonProperty("enable_dices")]
        public int EnableDices { get; set; }

        [JsonProperty("enable_flags")]
        public int EnableFlags { get; set; }

        [JsonProperty("enable_icons")]
        public int EnableIcons { get; set; }

        [JsonProperty("enable_images")]
        public int EnableImages { get; set; }

        [JsonProperty("enable_likes")]
        public int EnableLikes { get; set; }

        [JsonProperty("enable_names")]
        public int EnableNames { get; set; }

        [JsonProperty("enable_oekaki")]
        public int EnableOekaki { get; set; }

        [JsonProperty("enable_posting")]
        public int EnablePosting { get; set; }

        [JsonProperty("enable_sage")]
        public int EnableSage { get; set; }

        [JsonProperty("enable_shield")]
        public int EnableShield { get; set; }

        [JsonProperty("enable_subject")]
        public int EnableSubject { get; set; }

        [JsonProperty("enable_thread_tags")]
        public int EnableThreadTags { get; set; }

        [JsonProperty("enable_trips")]
        public int EnableTrips { get; set; }

        [JsonProperty("enable_video")]
        public int EnableVideo { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("max_comment")]
        public int MaxComment { get; set; }

        [JsonProperty("max_files_size")]
        public int MaxFilesSize { get; set; }

        [JsonProperty("news_abu")]
        public IList<NewsAbu> NewsAbu { get; set; }

        [JsonProperty("threads")]
        public IList<ThreadFull> Threads { get; set; }

        [JsonProperty("top")]
        public IList<Top> Top { get; set; }
    }


        
}