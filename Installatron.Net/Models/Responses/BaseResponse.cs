using System.Collections;
using Newtonsoft.Json;

namespace Installatron.Net.Models.Responses
{
    /// <summary>
    /// A base Installatron result
    /// </summary>
    public class BaseResponse
    {
        /// <summary>
        /// The raw response returned from the API
        /// </summary>
        public string RawResponse { get; set; }

        /// <summary>
        /// The request was success
        /// </summary>
        [JsonProperty("result")]
        public bool Success { get; set; }

        /// <summary>
        /// The message from the API
        /// </summary>
        public string Message { get; set; }
    }
}
