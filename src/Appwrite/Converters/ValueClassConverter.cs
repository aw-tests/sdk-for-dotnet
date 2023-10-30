using System;
using Appwrite.Enums;
using Newtonsoft.Json;

namespace Appwrite.Converters
{
    public class ValueClassConverter : JsonConverter {

        public override bool CanConvert(Type objectType)
        {
            return typeof(Browser).IsAssignableFrom(objectType) ||
typeof(CreditCard).IsAssignableFrom(objectType) ||
typeof(Flag).IsAssignableFrom(objectType) ||
typeof(RelationshipType).IsAssignableFrom(objectType) ||
typeof(RelationMutate).IsAssignableFrom(objectType) ||
typeof(IndexType).IsAssignableFrom(objectType) ||
typeof(Runtime).IsAssignableFrom(objectType) ||
typeof(Method).IsAssignableFrom(objectType) ||
typeof(Compression).IsAssignableFrom(objectType) ||
typeof(ImageGravity).IsAssignableFrom(objectType) ||
typeof(ImageFormat).IsAssignableFrom(objectType) ||
typeof(PasswordVersion).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = (string)reader.Value;
            var constructor = objectType.GetConstructor(new[] { typeof(string) });
            var obj = constructor.Invoke(new object[] { value });

            return Convert.ChangeType(obj, objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var type = value.GetType();
            var property = type.GetProperty("Value");
            var propertyValue = property.GetValue(value);

            if (propertyValue == null)
            {
                writer.WriteNull();
                return;
            }

            writer.WriteValue(propertyValue);
        }
    }
}
