using System;

namespace Appwrite.Enums
{
    public class IndexType
    {
        public string Value { get; private set; }

        public IndexType(string value)
        {
            Value = value;
        }

        public static IndexType Key => new IndexType("key");
        public static IndexType Fulltext => new IndexType("fulltext");
        public static IndexType Unique => new IndexType("unique");
        public static IndexType Spatial => new IndexType("spatial");
        public static IndexType Array => new IndexType("array");
    }
}
