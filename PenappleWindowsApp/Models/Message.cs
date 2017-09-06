using System;
using Newtonsoft.Json;
namespace PenscribCommon.Models
{
    public class Message : IModel
    {
        public ModelName type { get { return ModelName.Message; } }
        //snowflake id
        public string id { get; set; }

        public string Content { get; set; }

        public string SenderId { get; set; }

        // Server adds this
        public User Sender { get; set; }

        public string GroupChatID { get; set; }

        // Server handles this
        public string GraphicsLocation { get; set; }

        // Server add this
        public DateTime CreationDate { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public override bool Equals(object obj)
        {
            Message msg = obj as Message;

            if (msg != null)
            {
                return msg.id == id;
            }
            else
            {
                return false;
            }
        }

    }
}
