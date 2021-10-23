using GildedRoseKata;
using System.Collections.Generic;
using System.Linq;

namespace GildedRose
{
    public class UpdatableItemFactory
    {
        private const string AGED_BRIE = "Aged Brie";
        private const string BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";

        public static UpdatableItem BasedOn(Item item)
        {
            switch (item.Name)
            {
                case AGED_BRIE:
                    return new AgedBrie(item);
                case BACKSTAGE_PASSES:
                    return new BackstagePasses(item);
                case SULFURAS:
                    return new Sulfuras(item);
                default:
                    return new StandardItem(item);
            }
        }

        public static IEnumerable<UpdatableItem> BasedOn(IEnumerable<Item> items) => items.ToList().Select(x => BasedOn(x));
    }
}
