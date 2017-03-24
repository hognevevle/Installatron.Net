using System.Collections.Generic;
using Newtonsoft.Json;

namespace Installatron.Net.Models.Requests
{
    public class InstallApplicationRequest : BaseRequest
    {
        public InstallApplicationRequest()
        {
            Command = "install";
        }

        /// <summary>
        /// The ID of the application to be installed. For example, "wordpress" or "magento". 
        /// </summary>
        [JsonProperty("application")]
        public string Application { get; set; }

        /// <summary>
        /// The version of the application to be installed. Optional - default is the latest compatible version.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

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
        /// The URL to where the application should be installed.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// If the DNS will not resolve the provided url to the correct IP, use this argument to provide the correct IP. Optional, default is the IP address resolved via DNS.
        /// </summary>
        [JsonProperty("url_ip")]
        public string UrlIp { get; set; }

        /// <summary>
        /// The database server. Required if the application requires a database, can be omitted if database automation is implemented.
        /// </summary>
        [JsonProperty("db_host")]
        public string DatabaseHost { get; set; }

        /// <summary>
        /// The pre-created database. Required if the application requires a database, can be omitted if database automation is implemented.
        /// </summary>
        [JsonProperty("db_name")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// The pre-created database username. Required if the application requires a database, can be omitted if database automation is implemented.
        /// </summary>
        [JsonProperty("db_user")]
        public string DatabaseUser { get; set; }

        /// <summary>
        /// The pre-created database password. Required if the application requires a database, can be omitted if database automation is implemented.
        /// </summary>
        [JsonProperty("db_pass")]
        public string DatabasePassword { get; set; }

        /// <summary>
        /// The prefix applied to database tables. Optional, defaults to the prefix behavior configured at Installatron Admin > Features
        /// </summary>
        [JsonProperty("db_prefix")]
        public string DatabasePrefix { get; set; }

        /// <summary>
        /// If a different MySQL host value must be temporarily used to connect to the database, use this argument to provide the temporary address. Installed application files will be written with the "db_host" value, but Installatron will use "db_host_ip" while installing. Optional, typically omitted.
        /// </summary>
        [JsonProperty("db_host_ip")]
        public string DatabaseHostIp { get; set; }

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
        /// Set to "yes" for the sample/demo template.
        /// Set to "no" for the blank install template.
        /// Set to the ID of the template for a different template.
        /// </summary>
        [JsonProperty("content")]
        public bool Content { get; set; }
    }
}
