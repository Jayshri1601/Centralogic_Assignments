using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace TaskAPI.DTO
{
    public class empDTO
    {
        [JsonProperty(PropertyName = "taskName", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        [JsonProperty(PropertyName = "taskDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskDescription { get; set; }
    }
}
