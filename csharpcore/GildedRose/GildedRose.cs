using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class GildedRose
    {
        public void UpdateQuality(IEnumerable<UpdatableItem> items)
        {
            items.ToList().ForEach(x => x.Update());
        }
    }
}
