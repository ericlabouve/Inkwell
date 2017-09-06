using System;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace PenscribCommon.Models
{
    public class GroupChat : IModel
    {
        public ModelName type { get { return ModelName.Chat; } }

        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        public List<string> GroupMembers { get; set; }

        public List<User> GroupUsers { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastModified { get; set; }

        public string ImageLocation { get; set; }

        public string Name { get; set; }

        public Dictionary<string, string> LastSeenMsgPerUser { get; set; }

        public Dictionary<string, string> ChatSettings { get; set; }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
