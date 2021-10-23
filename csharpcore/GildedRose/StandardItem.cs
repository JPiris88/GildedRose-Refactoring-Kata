using GildedRoseKata;

namespace GildedRose
{
    public class StandardItem : Item
    {
        private const int DECREASE_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN = 0;

        public StandardItem(ItemName name, ItemSellIn sellIn, ItemQuality quality) : base(name, sellIn, quality)
        {
        }

        public override void Update()
        {
            DecreaseSellIn();

            DecreaseQuality();

            if (SellIn.IsLowerThan(DECREASE_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN))
            {
                DecreaseQuality();
            }
        }
    }
}
