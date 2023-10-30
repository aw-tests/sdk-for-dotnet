using System;

namespace Appwrite.Enums
{
    public class Method
    {
        public string Value { get; private set; }

        public Method(string value)
        {
            Value = value;
        }

        public static Method GET => new Method("GET");
        public static Method POST => new Method("POST");
        public static Method PUT => new Method("PUT");
        public static Method PATCH => new Method("PATCH");
        public static Method DELETE => new Method("DELETE");
        public static Method OPTIONS => new Method("OPTIONS");
    }
}
