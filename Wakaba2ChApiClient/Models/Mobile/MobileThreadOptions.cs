using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wakaba2ChApiClient.Models.Mobile
{
    public class MobileThreadOptions
    {
        /// <summary>
        /// Взрослым
        /// </summary>
        [JsonProperty("Взрослым")]
        public IList<ThreadOption> Adults { get; set; }


        /// <summary>
        /// Игры
        /// </summary>
        [JsonProperty("Игры")]
        public IList<ThreadOption> Games { get; set; }

        /// <summary>
        /// Политика
        /// </summary>
        [JsonProperty("Политика")]
        public IList<ThreadOption> Politic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Пользовательские")]
        public IList<ThreadOption> Custom { get; set; }

        /// <summary>
        /// Разное
        /// </summary>
        [JsonProperty("Разное")]
        public IList<ThreadOption> Misc { get; set; }

        /// <summary>
        /// Творчество
        /// </summary>
        [JsonProperty("Творчество")]
        public IList<ThreadOption> Art { get; set; }

        /// <summary>
        /// Тематика
        /// </summary>
        [JsonProperty("Тематика")]
        public IList<ThreadOption> Thematic { get; set; }

        /// <summary>
        /// Техника и софт
        /// </summary>
        [JsonProperty("Техника и софт")]
        public IList<ThreadOption> HardAndSoft { get; set; }

        /// <summary>
        /// Японская культура
        /// </summary>
        [JsonProperty("Японская культура")]
        public IList<ThreadOption> JapanCulture { get; set; }
    }
}