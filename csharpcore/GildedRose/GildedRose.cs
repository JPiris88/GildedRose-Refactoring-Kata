using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private const string AGED_BRIE = "Aged Brie";
        private const string BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        private const int MAXIMUM_QUALITY = 50;
        private const int MINIMUM_QUALITY = 0;
        private const int DOUBLE_BACKSTAGE_PASSES_QUALITY_WHEN_SELL_IN_LOWER_THAN = 11;
        private const int TRIPLE_BACKSTAGE_PASSES_QUALITY_WHEN_SELL_IN_LOWER_THAN = 6;
        private const int DECREASE_DEFAULT_ITEM_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN = 0;

        private readonly IList<Item> _items;

        public GildedRose(IList<Item> Items)
        {
            _items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                switch (item.Name)
                {
                    case AGED_BRIE:
                        DecreaseSellIn(item);
                        IncreaseAgedBrieQuality(item);
                        break;
                    case BACKSTAGE_PASSES:
                        IncreaseBackstagePassesQuality(item);
                        DecreaseSellIn(item);
                        DropBackstagePassesQualityToZero(item);
                        break;
                    case SULFURAS:
                        break;
                    default:
                        DecreaseSellIn(item);
                        DecreaseDefaultItemQuality(item);
                        break;
                }
            }
        }

        private void DropBackstagePassesQualityToZero(Item item)
        {
            if (item.SellIn < DECREASE_DEFAULT_ITEM_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN)
            {
                DropQualityToZero(item);
            }
        }

        private void DecreaseDefaultItemQuality(Item item)
        {
            DecreaseQuality(item);

            if (item.SellIn < DECREASE_DEFAULT_ITEM_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN)
            {
                DecreaseQuality(item);
            }
        }

        private void IncreaseBackstagePassesQuality(Item item)
        {
            IncreaseQuality(item);

            if (item.SellIn < DOUBLE_BACKSTAGE_PASSES_QUALITY_WHEN_SELL_IN_LOWER_THAN)
            {
                IncreaseQuality(item);
            }

            if (item.SellIn < TRIPLE_BACKSTAGE_PASSES_QUALITY_WHEN_SELL_IN_LOWER_THAN)
            {
                IncreaseQuality(item);
            }
        }

        private void IncreaseAgedBrieQuality(Item item)
        {
            IncreaseQuality(item);

            if (item.SellIn < DECREASE_DEFAULT_ITEM_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN)
            {
                IncreaseQuality(item);
            }
        }

        private void DropQualityToZero(Item item)
        {
            item.Quality = 0;
        }

        private void DecreaseSellIn(Item item)
        {
            item.SellIn--;
        }

        private void DecreaseQuality(Item item)
        {
            if (item.Quality > MINIMUM_QUALITY)
            {
                item.Quality--;
            }
        }

        private void IncreaseQuality(Item item)
        {
            if (item.Quality < MAXIMUM_QUALITY)
            {
                item.Quality++;
            }
        }
    }
}
