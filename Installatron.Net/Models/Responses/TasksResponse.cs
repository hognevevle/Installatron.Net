using System.Collections.Generic;
using Newtonsoft.Json;

namespace Installatron.Net.Models.Responses
{
    public class TasksResponse : BaseResponse
    {
        /// <summary>
        /// List of currently executing and recently completed tasks.
        /// </summary>
        public IEnumerable<TasksResponseDataItem> Data { get; set; }
    }

    public class TasksResponseDataItem
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("ws_label")]
        public string WsLabel { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("rate")]
        public int Rate { get; set; }

        [JsonProperty("percentMin")]
        public int PercentMin { get; set; }

        [JsonProperty("percentMax")]
        public int PercentMax { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("cmd")]
        public string Cmd { get; set; }

        [JsonProperty("install")]
        public string Install { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }
    }
}
