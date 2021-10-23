using GildedRoseKata;

namespace GildedRose
{
    public class AgedBrie : UpdatableItem
    {
        private const int INCREASE_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN = 0;

        public AgedBrie(Item item) : base(item)
        {
        }

        public override void Update()
        {
            DecreaseSellIn();

            IncreaseQuality();

            if (SellIn() < INCREASE_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN)
            {
                IncreaseQuality();
            }
        }
    }
}
