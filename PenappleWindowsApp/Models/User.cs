using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PenscribCommon.Models
{
    public class User : IModel
    {
        public ModelName type { get { return ModelName.User; } }
        public ProviderType Provider { get; set; }

        public string id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Name { get { return FirstName + " " + LastName; } private set { } }

        public string Username { get; set; }

        public string Email { get; set; }

        public string ProfilePicLocation { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public override bool Equals(object obj)
        {
            User usr = obj as User;

            if (usr != null)
            {
                return usr.id == id;
            }
            else
            {
                return false;
            }
        }
    }
}
