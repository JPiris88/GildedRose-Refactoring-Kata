using System;

namespace GildedRose
{
    public class ItemName
    {
        public string Value { get; }

        public ItemName(string value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is ItemName name &&
                   Value == name.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}
