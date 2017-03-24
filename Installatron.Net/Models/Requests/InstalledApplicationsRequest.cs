using System.Collections.Generic;
using Newtonsoft.Json;

namespace Installatron.Net.Models.Requests
{
    public class InstalledApplicationsRequest : BaseRequest
    {
        public InstalledApplicationsRequest()
        {
            Command = "installs";
        }

        /// <summary>
        /// Search installed application with a query. This searches the title, url, id, installer, and owner fields. Optional.
        /// </summary>
        [JsonProperty("q")]
        public string Search { get; set; }

        /// <summary>
        /// Display a specific installed application by ID. Optional.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// When set equal to "yes", only installed applications that have any new version upgrades available will be listed. Optional.
        /// </summary>
        [JsonProperty("filter-version-available")]
        public string FilterOnlyVersionUpgrades { get; set; }

        /// <summary>
        /// When set equal to "yes", only installed applications that have new minor version upgrades available will be listed. Optional.
        /// </summary>
        [JsonProperty("filter-version-available-minor")]
        public string FilterOnlyMinorVersionUpgrades { get; set; }
    }
}
