
using System;
using System.Linq;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Appwrite.Models
{
    public class AttributeRelationship
    {
        [JsonProperty("key")]
        public string Key { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("required")]
        public bool Required { get; private set; }

        [JsonProperty("array")]
        public bool? Array { get; private set; }

        [JsonProperty("relatedCollection")]
        public string RelatedCollection { get; private set; }

        [JsonProperty("relationType")]
        public string RelationType { get; private set; }

        [JsonProperty("twoWay")]
        public bool TwoWay { get; private set; }

        [JsonProperty("twoWayKey")]
        public string TwoWayKey { get; private set; }

        [JsonProperty("onDelete")]
        public string OnDelete { get; private set; }

        [JsonProperty("side")]
        public string Side { get; private set; }

        public AttributeRelationship(
            string key,
            string type,
            string status,
            bool required,
            bool? array,
            string relatedCollection,
            string relationType,
            bool twoWay,
            string twoWayKey,
            string onDelete,
            string side
        ) {
            Key = key;
            Type = type;
            Status = status;
            Required = required;
            Array = array;
            RelatedCollection = relatedCollection;
            RelationType = relationType;
            TwoWay = twoWay;
            TwoWayKey = twoWayKey;
            OnDelete = onDelete;
            Side = side;
        }

        public static AttributeRelationship From(Dictionary<string, object> map) => new AttributeRelationship(
            key: (string)map["key"],
            type: (string)map["type"],
            status: (string)map["status"],
            required: (bool)map["required"],
            array: (bool?)map["array"],
            relatedCollection: (string)map["relatedCollection"],
            relationType: (string)map["relationType"],
            twoWay: (bool)map["twoWay"],
            twoWayKey: (string)map["twoWayKey"],
            onDelete: (string)map["onDelete"],
            side: (string)map["side"]
        );

        public Dictionary<string, object?> ToMap() => new Dictionary<string, object?>()
        {
            { "key", Key },
            { "type", Type },
            { "status", Status },
            { "required", Required },
            { "array", Array },
            { "relatedCollection", RelatedCollection },
            { "relationType", RelationType },
            { "twoWay", TwoWay },
            { "twoWayKey", TwoWayKey },
            { "onDelete", OnDelete },
            { "side", Side }
        };
    }
}