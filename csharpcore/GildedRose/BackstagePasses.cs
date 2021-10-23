using GildedRoseKata;

namespace GildedRose
{
    public class BackstagePasses : Item
    {
        private const int DOUBLE_QUALITY_WHEN_SELL_IN_LOWER_THAN = 11;
        private const int TRIPLE_QUALITY_WHEN_SELL_IN_LOWER_THAN = 6;
        private const int DROP_QUALITY_TO_ZERO_WHEN_SELL_IN_LOWER_THAN = 0;

        public BackstagePasses(ItemSellIn sellIn, ItemQuality quality) : base(new ItemName("Backstage passes to a TAFKAL80ETC concert"), sellIn, quality)
        {
        }

        public override void Update()
        {
            IncreaseQuality();

            if (SellIn.IsLowerThan(DOUBLE_QUALITY_WHEN_SELL_IN_LOWER_THAN))
            {
                IncreaseQuality();
            }

            if (SellIn.IsLowerThan(TRIPLE_QUALITY_WHEN_SELL_IN_LOWER_THAN))
            {
                IncreaseQuality();
            }

            DecreaseSellIn();

            if (SellIn.IsLowerThan(DROP_QUALITY_TO_ZERO_WHEN_SELL_IN_LOWER_THAN))
            {
                DropQualityToZero();
            }
        }
    }
}
