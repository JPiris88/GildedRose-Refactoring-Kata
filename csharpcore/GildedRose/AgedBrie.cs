using GildedRoseKata;

namespace GildedRose
{
    public class AgedBrie : Item
    {
        private const int INCREASE_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN = 0;

        public AgedBrie(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void Update()
        {
            DecreaseSellIn();

            IncreaseQuality();

            if (SellIn < INCREASE_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN)
            {
                IncreaseQuality();
            }
        }
    }
}
