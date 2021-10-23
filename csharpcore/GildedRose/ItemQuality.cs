using System;

namespace GildedRose
{
    public class ItemQuality
    {
        private const int MAXIMUM_QUALITY = 50;
        private const int MINIMUM_QUALITY = 0;

        public int Value { get; }

        public ItemQuality(int value)
        {
            Value = value;
        }

        public ItemQuality DropToZero()
        {
            return new ItemQuality(0);
        }

        public ItemQuality Increase()
        {
            if (Value == MAXIMUM_QUALITY) return this;

            return new ItemQuality(Value + 1);
        }

        public ItemQuality Decrease()
        {
            if (Value == MINIMUM_QUALITY) return this;

            return new ItemQuality(Value - 1);
        }

        public override bool Equals(object obj)
        {
            return obj is ItemQuality quality &&
                   Value == quality.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}
