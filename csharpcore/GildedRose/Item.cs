using GildedRose;

namespace GildedRoseKata
{
    public abstract class Item
    {
        public ItemName Name { get; private set; }
        public ItemQuality Quality { get; private set; }
        public ItemSellIn SellIn { get; private set; }

        public Item(ItemName name, ItemSellIn sellIn, ItemQuality quality)
        {
            Name = name;
            Quality = quality;
            SellIn = sellIn;
        }

        public abstract void Update();

        protected void DropQualityToZero()
        {
            Quality = Quality.DropToZero();
        }

        protected void DecreaseSellIn()
        {
            SellIn = SellIn.Decrease();
        }

        protected void DecreaseQuality()
        {
            Quality = Quality.Decrease();
        }

        protected void IncreaseQuality()
        {
            Quality = Quality.Increase();
        }
    }
}
