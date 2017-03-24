using System;
using System.IO;
using System.Net;
using System.Text;
using Installatron.Net.Helpers;
using Installatron.Net.Models.Requests;
using Installatron.Net.Models.Responses;
using Newtonsoft.Json;

namespace Installatron.Net
{
    /// <summary>
    /// Client for interacting with the Installatron HTTP API
    /// </summary>
    public class InstallatronClient
    {
        private readonly string _apiUrl;
        private readonly string _apiKey;

        /// <summary>
        /// Creates an instance of the Installatron client
        /// </summary>
        /// <param name="apiUrl">The base url to the HTTP api, e.g. https://installatron.example.com:8080/installatron/</param>
        /// <param name="apiKey">The API authentication key. This is provided by Installatron when hosted as a service. Check the "key" value in /usr/local/installatron/etc/settings.ini for self-hosted instances.</param>
        public InstallatronClient(string apiUrl, string apiKey)
        {
            _apiUrl = apiUrl;
            _apiKey = apiKey;
        }

        /// <summary>
        /// List available applications and application information
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public AvailableApplicationsResponse ListAvailableApplications(AvailableApplicationsRequest data)
        {
            return Execute<AvailableApplicationsResponse>(data);
        }

        /// <summary>
        /// Install an application
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public InstallApplicationResponse InstallApplication(InstallApplicationRequest data)
        {
            return Execute<InstallApplicationResponse>(data);
        }

        /// <summary>
        /// Edit an application
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public EditApplicationResponse EditApplication(EditApplicationRequest data)
        {
            return Execute<EditApplicationResponse>(data);
        }

        /// <summary>
        /// List currently executing and recently completed tasks
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public TasksResponse ListTasks(TasksRequest data)
        {
            return Execute<TasksResponse>(data);
        }

        /// <summary>
        /// List installed applications
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public InstalledApplicationsResponse ListInstalledApplications(InstalledApplicationsRequest data)
        {
            return Execute<InstalledApplicationsResponse>(data);
        }

        private TResult Execute<TResult>(BaseRequest requestData)
            where TResult : BaseResponse, new()
        {
            requestData.ApiKey = _apiKey;

            var client = new WebClient();
            var libraryVersion = InstallatronHelpers.GetVersion();
            var runtimeVersion = InstallatronHelpers.GetSystemInfo();
            var userAgent = $"Installatron.Net/{libraryVersion} ({runtimeVersion})";

            // Set a custom user agent
            client.Headers.Add("user-agent", userAgent);

            try
            {
                var jsonData = JsonConvert.SerializeObject(requestData);
                var response = client.UploadData(_apiUrl, Encoding.UTF8.GetBytes(jsonData));
                var textResponse = Encoding.UTF8.GetString(response);

                var apiResponse = JsonConvert.DeserializeObject<TResult>(textResponse);
                apiResponse.RawResponse = textResponse;
                
                return apiResponse;
            }
            catch (WebException webex)
            {
                var response = webex.Response.GetResponseStream();

                if (response == null)
                {
                    throw new Exception("Response was null");
                }

                string body;
                using (var reader = new StreamReader(response))
                {
                    body = reader.ReadToEnd();
                }

                var result = JsonConvert.DeserializeObject<TResult>(body);
                result.RawResponse = body;
                
                return result;
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}
