using GildedRoseKata;

namespace GildedRose
{
    public class AgedBrie : Item
    {
        private const int INCREASE_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN = 0;

        public AgedBrie(ItemSellIn sellIn, ItemQuality quality) : base(new ItemName("Aged Brie"), sellIn, quality)
        {
        }

        public override void Update()
        {
            DecreaseSellIn();

            IncreaseQuality();

            if (SellIn.IsLowerThan(INCREASE_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN))
            {
                IncreaseQuality();
            }
        }
    }
}
