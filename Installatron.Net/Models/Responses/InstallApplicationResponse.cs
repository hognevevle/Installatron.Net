using System.Collections.Generic;
using Newtonsoft.Json;

namespace Installatron.Net.Models.Responses
{
    public class InstallApplicationResponse : BaseResponse
    {
        [JsonProperty("data")]
        public InstallApplicationResponseDataItem Data { get; set; }

        /// <summary>
        /// Table of task information if executed as a background process.
        /// </summary>
        public string Task { get; set; }
    }

    public class InstallApplicationResponseDataItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("installer")]
        public string Installer { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("agent")]
        public string Agent { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("path-created")]
        public string PathCreated { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("url-domain")]
        public string UrlDomain { get; set; }

        [JsonProperty("db-host")]
        public string DbHost { get; set; }

        [JsonProperty("db-type")]
        public string DbType { get; set; }

        [JsonProperty("db-name")]
        public string DbName { get; set; }

        [JsonProperty("db-user")]
        public string DbUser { get; set; }

        [JsonProperty("db-pass")]
        public string DbPass { get; set; }

        [JsonProperty("db-prefix")]
        public string DbPrefix { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("list-files")]
        public IEnumerable<string> ListFiles { get; set; }

        [JsonProperty("list-tables")]
        public IEnumerable<string> ListTables { get; set; }

        [JsonProperty("autoup")]
        public string Autoup { get; set; }

        [JsonProperty("bkloc")]
        public string Bkloc { get; set; }

        [JsonProperty("autobk")]
        public string Autobk { get; set; }

        [JsonProperty("cf-login")]
        public string CfLogin { get; set; }

        [JsonProperty("cf-email")]
        public string CfEmail { get; set; }

        [JsonProperty("cf-sitetitle")]
        public string CfSitetitle { get; set; }

        [JsonProperty("cf-sitetagline")]
        public string CfSitetagline { get; set; }

        [JsonProperty("cf-limitloginattempts")]
        public string CfLimitloginattempts { get; set; }

        [JsonProperty("cache-tables")]
        public string CacheTables { get; set; }

        [JsonProperty("link-admin")]
        public string LinkAdmin { get; set; }

        [JsonProperty("cache-files")]
        public string CacheFiles { get; set; }

        [JsonProperty("cache-time")]
        public string CacheTime { get; set; }

        [JsonProperty("cache-numbackups")]
        public string CacheNumbackups { get; set; }
    }
}
