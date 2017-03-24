using System.Collections.Generic;
using Newtonsoft.Json;

namespace Installatron.Net.Models.Requests
{
    public class AvailableApplicationsRequest : BaseRequest
    {
        public AvailableApplicationsRequest()
        {
            Command = "browser";
        }

        /// <summary>
        /// The ID of the application to list available versions of. The list may contain a single application or multiple applications. By default the latest version of each application is listed. Listed versions are ordered correctly. Optional.
        /// </summary>
        [JsonProperty("application")]
        public IEnumerable<string> Application { get; set; }

        /// <summary>
        /// If application is set to one application, set this to only list the specific version. Optional.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// If application is set to one application, set this to list all versions from specified version to the latest version. Each listed version includes a "upgrade_from" member which reveals whether an install at the specified version can upgraded to the listed version (values of "none" or "manual" mean it cannot). Listed versions are ordered correctly. Optional.
        /// </summary>
        [JsonProperty("from-version")]
        public string FromVersion { get; set; }

        /// <summary>
        /// If application is set to one application, instead of the usual output this will return two lists, "versions-available" and "versions-available-minor", each listing the versions upgradable to from the specified value. Optional.
        /// </summary>
        [JsonProperty("versions-available-from")]
        public string VersionsAvailableFrom { get; set; }

        /// <summary>
        /// The language application information should be returned in. For example, "en" for English or "zh_tw" for Chinese Traditional. If omitted, the defined website's default language or English is assumed. See: https://secure.installatron.com/translator.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }
    }
}
