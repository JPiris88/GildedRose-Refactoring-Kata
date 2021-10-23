using GildedRoseKata;

namespace GildedRose
{
    public class BackstagePasses : UpdatableItem
    {
        private const int DOUBLE_QUALITY_WHEN_SELL_IN_LOWER_THAN = 11;
        private const int TRIPLE_QUALITY_WHEN_SELL_IN_LOWER_THAN = 6;
        private const int DROP_QUALITY_TO_ZERO_WHEN_SELL_IN_LOWER_THAN = 0;

        public BackstagePasses(Item item) : base(item)
        {
        }

        public override void Update()
        {
            IncreaseQuality();

            if (SellIn() < DOUBLE_QUALITY_WHEN_SELL_IN_LOWER_THAN)
            {
                IncreaseQuality();
            }

            if (SellIn() < TRIPLE_QUALITY_WHEN_SELL_IN_LOWER_THAN)
            {
                IncreaseQuality();
            }

            DecreaseSellIn();

            if (SellIn() < DROP_QUALITY_TO_ZERO_WHEN_SELL_IN_LOWER_THAN)
            {
                DropQualityToZero();
            }
        }
    }
}
