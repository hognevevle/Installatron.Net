using System.Collections.Generic;
using Newtonsoft.Json;

namespace Installatron.Net.Models.Responses
{
    public class EditApplicationResponse : BaseResponse
    {
        /// <summary>
        /// Further details regarding the success or failure.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
