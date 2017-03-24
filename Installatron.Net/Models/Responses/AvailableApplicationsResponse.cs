using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Installatron.Net.Models.Responses
{
    public class AvailableApplicationsResponse : BaseResponse
    {
        /// <summary>
        /// The data returned from the API
        /// </summary>
        public IEnumerable<AvailableApplicationItem> Data { get; set; }
    }

    public class AvailableApplicationItem : BaseResponse
    {
        /// <summary>
        /// The ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The application ID
        /// </summary>
        [JsonProperty("appid")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The application version
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// A branch, e.g. "current"
        /// </summary>
        [JsonProperty("branch")]
        public string Branch { get; set; }

        /// <summary>
        /// The application name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The application name
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// The application name
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The release date
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// License type
        /// </summary>
        [JsonProperty("license")]
        public string License { get; set; }

        /// <summary>
        /// List of application tags
        /// </summary>
        [JsonProperty("tags")]
        public IEnumerable<string> tags { get; set; }

        /// <summary>
        /// Application description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Author description
        /// </summary>
        [JsonProperty("authordescription")]
        public string AuthorDescription { get; set; }

        /// <summary>
        /// Upgrade type
        /// </summary>
        [JsonProperty("upgrade")]
        public string Upgrade { get; set; }

        /// <summary>
        /// Install type
        /// </summary>
        [JsonProperty("install")]
        public string Install { get; set; }

        /// <summary>
        /// Application web site
        /// </summary>
        [JsonProperty("link_site")]
        public string LinkSite { get; set; }

        /// <summary>
        /// Application documentation web site
        /// </summary>
        [JsonProperty("link_docs")]
        public string LinkDocs { get; set; }

        /// <summary>
        /// Application FAQ web site
        /// </summary>
        [JsonProperty("link_faq")]
        public string LinkFaq { get; set; }

        /// <summary>
        /// Application support web site
        /// </summary>
        [JsonProperty("link_support")]
        public string LinkSupport { get; set; }

        /// <summary>
        /// Application changelog web site
        /// </summary>
        [JsonProperty("link_changelog")]
        public string LinkChangelog { get; set; }

        /// <summary>
        /// Application administration page
        /// </summary>
        [JsonProperty("link_admin")]
        public string LinkAdmin { get; set; }

        /// <summary>
        /// The required disk space for the application in MB
        /// </summary>
        [JsonProperty("requirement_diskspace")]
        public string RequirementDiskspace { get; set; }

        /// <summary>
        /// True if the application requires a database
        /// </summary>
        [JsonProperty("requirement_database")]
        public bool RequirementDatabase { get; set; }

        /// <summary>
        /// The required database type, either null, "mysql" or "mssql"
        /// </summary>
        [JsonProperty("requirement_db_type")]
        public string RequirementDatabaseType { get; set; }

        /// <summary>
        /// Requires database prefix support
        /// </summary>
        [JsonProperty("requirement_db_prefix_support")]
        public bool RequirementDatabasePrefixSupport { get; set; }

        /// <summary>
        /// Requires database prefix underscore
        /// </summary>
        [JsonProperty("requirement_db_prefix_underscore")]
        public bool RequirementDatabasePrefixUnderscore { get; set; }

        /// <summary>
        /// The minimum supported PHP version
        /// </summary>
        [JsonProperty("requirement_php_version_minimum")]
        public string RequirementMinimumPhpVersion { get; set; }

        /// <summary>
        /// The minimum supported MySQL version
        /// </summary>
        [JsonProperty("requirement_mysql_version_minimum")]
        public string RequirementMinimumMySqlVersion { get; set; }

        /// <summary>
        /// The minimum supported GD version
        /// </summary>
        [JsonProperty("requirement_php_gd_version_minimum")]
        public string RequirementMinimumGdVersion { get; set; }

        /// <summary>
        /// Available languages
        /// </summary>
        [JsonProperty("languages")]
        public IEnumerable<string> Languages { get; set; }

        /// <summary>
        /// Image files
        /// </summary>
        [JsonProperty("images")]
        public IEnumerable<string> Images { get; set; }

        /// <summary>
        /// The minimum supported GD version
        /// </summary>
        [JsonProperty("fields")]
        public Dictionary<string, AvailableApplicationFieldItem> Fields { get; set; }
    }

    public class AvailableApplicationFieldItem
    {
        /// <summary>
        /// Describing label
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// Additional description
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Field type, e.g. "text"
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Field value
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Default value
        /// </summary>
        [JsonProperty("default")]
        public string Default { get; set; }

        /// <summary>
        /// Readonly
        /// </summary>
        [JsonProperty("readonly")]
        public string Readonly { get; set; }

        /// <summary>
        /// Readable
        /// </summary>
        [JsonProperty("gettable")]
        public bool Gettable { get; set; }

        /// <summary>
        /// Writeable
        /// </summary>
        [JsonProperty("settable")]
        public bool Settable { get; set; }

        /// <summary>
        /// Sort order
        /// </summary>
        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        /// <summary>
        /// Options
        /// </summary>
        [JsonProperty("options")]
        public Dictionary<string,string> Options { get; set; }
    }
}
