using GildedRoseKata;

namespace GildedRose
{
    public class StandardItem : UpdatableItem
    {
        private const int DECREASE_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN = 0;

        public StandardItem(Item item) : base(item)
        {
        }

        public override void Update()
        {
            DecreaseSellIn();

            DecreaseQuality();

            if (SellIn() < DECREASE_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN)
            {
                DecreaseQuality();
            }
        }
    }
}
