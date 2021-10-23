using GildedRoseKata;

namespace GildedRose
{
    public class Conjured : Item
    {
        private const int DECREASE_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN = 0;

        public Conjured(ItemSellIn sellIn, ItemQuality quality) : base(new ItemName("Conjured Mana Cake"), sellIn, quality)
        {
        }

        public override void Update()
        {
            DecreaseSellIn();

            DecreaseQuality();
            DecreaseQuality();

            if (SellIn.IsLowerThan(DECREASE_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN))
            {
                DecreaseQuality();
                DecreaseQuality();
            }
        }
    }
}
