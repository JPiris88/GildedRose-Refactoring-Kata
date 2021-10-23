using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class GildedRose
    {
        public void UpdateQuality(IEnumerable<Item> items)
        {
            items.ToList().ForEach(x => x.Update());
        }
    }
}
