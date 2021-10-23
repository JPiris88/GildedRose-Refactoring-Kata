using System;

namespace GildedRose
{
    public class ItemSellIn
    {
        public int Value { get; }

        public ItemSellIn(int value)
        {
            Value = value;
        }

        public ItemSellIn Decrease()
        {
            return new ItemSellIn(Value - 1);
        }

        public bool IsLowerThan(int value)
        {
            return Value < value;
        }

        public override bool Equals(object obj)
        {
            return obj is ItemSellIn @in &&
                   Value == @in.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}
