using System;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
namespace PenscribCommon.Models
{
	public enum ModelName { Message, User, Chat, Provider }

	public interface IModel
	{
		[JsonPropertyAttribute(PropertyName = "id")]
		string id { get; set; }
		ModelName type { get; }
	}

}
