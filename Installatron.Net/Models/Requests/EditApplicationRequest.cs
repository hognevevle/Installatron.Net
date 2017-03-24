using System.Collections.Generic;
using Newtonsoft.Json;

namespace Installatron.Net.Models.Requests
{
    public class EditApplicationRequest : BaseRequest
    {
        /// <remarks>
        /// All null properties will leave their values unchanged.
        /// </remarks>
        public EditApplicationRequest()
        {
            Command = "edit";
        }

        /// <summary>
        /// The ID of the installed application to be updated.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The URL to the installed application. Optional, defaults to the existing value
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Change automatic update configuration. Values: 0 = Off (default); 1 = Update to minor versions only; 2 = Update to any version. Optional.
        /// </summary>
        [JsonProperty("autoup")]
        public int AutoUpdate { get; set; }

        /// <summary>
        /// Automatically create a backup and automatically restore the backup if the update fails. Values: 0 = Off; 1 = On (default). Optional.
        /// </summary>
        [JsonProperty("autoup_backup")]
        public int AutoUpdateBackup { get; set; }

        /// <summary>
        /// List of email notifications to send for the installed application (each separated with a comma). Omit this argument entirely to send all notifications, or define an empty string to send no notifications.
        /// </summary>
        /// <list type="bullet">
        /// <item><description>install</description></item>
        /// <item><description>install_error</description></item>
        /// <item><description>clone</description></item>
        /// <item><description>clone_error</description></item>
        /// <item><description>backup</description></item>
        /// <item><description>backup_error</description></item>
        /// <item><description>restore</description></item>
        /// <item><description>restore_error</description></item>
        /// <item><description>update_available</description></item>
        /// <item><description>update</description></item>
        /// <item><description>update_error</description></item>
        /// <item><description>plugin_update_available</description></item>
        /// <item><description>plugin_update</description></item>
        /// <item><description>plugin_update_error</description></item>
        /// </list>
        [JsonProperty("notification")]
        public IEnumerable<string> Notification { get; set; }

        /// <summary>
        /// The server that hosts the installed application's database.
        /// </summary>
        [JsonProperty("db_host")]
        public string DatabaseHost { get; set; }

        /// <summary>
        /// The name of the installed application's database.
        /// </summary>
        [JsonProperty("db_name")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// The database username used to connect to the installed application's database.
        /// </summary>
        [JsonProperty("db_user")]
        public string DatabaseUser { get; set; }

        /// <summary>
        /// The database username password.
        /// </summary>
        [JsonProperty("db_pass")]
        public string DatabasePassword { get; set; }

        /// <summary>
        /// The prefix each database table begins with, including trailing underscore (if any).
        /// </summary>
        [JsonProperty("db_prefix")]
        public string DatabasePrefix { get; set; }

        /// <summary>
        /// When defined, the request will exit immediately and the task will be transferred to a background process after preliminary error checking. 
        /// </summary>
        /// <seealso cref="InstallatronClient.ListTasks"/>
        [JsonProperty("background")]
        public bool Background { get; set; }

        /// <summary>
        /// The language of the application to be installed. For example, "en" for English or "zh_tw" for Chinese Traditional. 
        /// </summary>
        /// <seealso cref="InstallatronClient.ListAvailableApplications"/>
        [JsonProperty("language")]
        public bool Language { get; set; }

        /// <summary>
        /// The username for the installed application's administrative account. Optional, default is randomly generated value
        /// </summary>
        [JsonProperty("login")]
        public bool Login { get; set; }

        /// <summary>
        /// The password for the installed application's administrative account. If omitted, a randomized password is assumed. 
        /// </summary>
        [JsonProperty("passwd")]
        public bool Password { get; set; }

        /// <summary>
        /// The site title value for the installed application. Optional, default is "My blog" or similar
        /// </summary>
        [JsonProperty("sitetitle")]
        public bool SiteTitle { get; set; }

        /// <summary>
        /// Set to 'true' to delete any backups connected to the installed application from the Installatron database. The backup archives will be unaffected.
        /// </summary>
        [JsonProperty("delete-backups")]
        public bool? DeleteBackupsFromDatabase { get; set; }

        /// <summary>
        /// Set to 'true' to delete the installed application from the Installatron database only. The installed application files and tables will be unaffected.
        /// </summary>
        [JsonProperty("delete")]
        public bool? DeleteFromDatabase { get; set; }
    }
}
