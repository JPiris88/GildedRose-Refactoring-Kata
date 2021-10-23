namespace GildedRoseKata
{
    public abstract class Item
    {
        private const int MAXIMUM_QUALITY = 50;
        private const int MINIMUM_QUALITY = 0;

        public string Name { get; private set; }
        public int Quality { get; private set; }
        public int SellIn { get; private set; }

        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            Quality = quality;
            SellIn = sellIn;
        }

        public abstract void Update();

        protected void DropQualityToZero()
        {
            Quality = 0;
        }

        protected void DecreaseSellIn()
        {
            SellIn--;
        }

        protected void DecreaseQuality()
        {
            if (Quality > MINIMUM_QUALITY)
            {
                Quality--;
            }
        }

        protected void IncreaseQuality()
        {
            if (Quality < MAXIMUM_QUALITY)
            {
                Quality++;
            }
        }
    }
}
