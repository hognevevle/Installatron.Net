using System.Collections.Generic;
using Newtonsoft.Json;

namespace Installatron.Net.Models.Requests
{
    public class TasksRequest : BaseRequest
    {
        public TasksRequest()
        {
            Command = "tasks";
        }
    }
}
