using System.Collections.Generic;
using Newtonsoft.Json;

namespace Installatron.Net.Models.Requests
{
    public class BaseRequest
    {
        /// <summary>
        /// The API we're targeting.
        /// </summary>
        [JsonProperty("api")]
        internal string Api => "json";

        /// <summary>
        /// Placeholder for the API key. Its value is provided in the InstallatronClient constructor.
        /// </summary>
        [JsonProperty("key")]
        internal string ApiKey { get; set; }

        /// <summary>
        /// The API command.
        /// </summary>
        [JsonProperty("cmd")]
        protected string Command { get; set; }

        /// <summary>
        /// An alphanumeric value that the list of websites provided for the current session can be associated with. This argument will be used to index data and cannot change. Optional, but recommended.
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// List of websites with each containing the below arguments. Note: Websites can only have one home directory so websites spread across multiple home directories will need separate website entries. See examples below.
        /// </summary>
        [JsonProperty("websites")]
        public IEnumerable<RequestWebsiteItem> Websites { get; set; }
    }

    public class RequestWebsiteItem
    {
        /// <summary>
        /// An alphanumeric value that will uniquely identify this website. This argument will be used to index data for this website and cannot change.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A value that will uniquely identify this website that can contain any characters. This argument can change.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// A value that will uniquely identify this website that can contain any characters. This argument can change.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary> 
        /// The path or URI to the home directory of this account (without a trailing directory separator). See https://secure.installatron.com/developer/server#3.1 for detailed documentation.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary> 
        /// A set of key/value pairs that define each domain hosted by this website and its corresponding document root relative to path. Example: http://installatron.com => public_html
        /// </summary>
        [JsonProperty("vhosts")]
        public Dictionary<string,string> Vhosts { get; set; }

        /// <summary> 
        /// The IP address each domain listed in vhosts should resolve to, enabling Installatron Server to install to vhosts that might not resolve through DNS. Optional, default is the IP address resolved via DNS
        /// </summary>
        [JsonProperty("vhost_ip")]
        public string VhostIp { get; set; }

        /// <summary> 
        /// A path relative to path where installed application backups will be saved, without a trailing directory separator. Default is /application_backups/.
        /// </summary>
        [JsonProperty("path_backups")]
        public string BackupsPath { get; set; }

        /// <summary> 
        /// The host portion of the path URI is used to distinguish between web servers by default. If for whatever reason this doesn't correctly distinguish web servers then a unique value for each web server should be set here. Optional, default is host portion of the path URI.
        /// </summary>
        [JsonProperty("server")]
        public string Server { get; set; }

        /// <summary> 
        /// The filesystem POSIX UID that files should be created as for this website. This value should only be included if path is a local filesystem path. 
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary> 
        /// The filesystem POSIX GID that files should be created as for this website. This value should only be included if path is a local filesystem path.
        /// </summary>
        [JsonProperty("gid")]
        public string Gid { get; set; }

        /// <summary> 
        /// The default mysql server for this website. This value will be overridden if a different database host value is defined for an installed application. Default is 'localhost'.
        /// </summary>
        [JsonProperty("mysql_host")]
        public string MySqlHost { get; set; }

        /// <summary> 
        /// This website's default language. This is the language text strings and error messages will display in for requests involving this website. For example, "en" for English or "nl" for Dutch. See: https://secure.installatron.com/translator. Optional, default is the systemwide default language or English
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary> 
        /// Whether the website is suspended. Valid values are "yes" and "no". Optional, default is "no"
        /// </summary>
        [JsonProperty("suspended")]
        public string Suspended { get; set; }
    }
}
