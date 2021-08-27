﻿using System.Collections.Generic;

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
                if (item.Name == AGED_BRIE)
                {
                    IncreaseQuality(item);
                }
                else if (item.Name == BACKSTAGE_PASSES)
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
                else if (item.Name == SULFURAS)
                {

                }
                else if (item.Quality > MINIMUM_QUALITY)
                {
                    item.Quality--;
                }

                if (item.Name != SULFURAS)
                {
                    item.SellIn--;
                }

                if (item.SellIn >= DECREASE_DEFAULT_ITEM_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN)
                    continue;

                if (item.Name == AGED_BRIE)
                {
                    IncreaseQuality(item);
                }
                else if (item.Name == BACKSTAGE_PASSES)
                {
                    item.Quality = 0;
                }
                else if (item.Name == SULFURAS)
                {

                }
                else if (item.Quality > MINIMUM_QUALITY)
                {
                    item.Quality--;
                }
            }
        }

        private static void IncreaseQuality(Item item)
        {
            if (item.Quality < MAXIMUM_QUALITY)
            {
                item.Quality++;
            }
        }
    }
}
