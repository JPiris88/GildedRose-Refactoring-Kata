using GildedRose;
using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseShould
    {
        [Fact]
        public void decrease_items_quality_by_two_when_sell_by_date_has_passed()
        {
            var item = new Item { Name = "A product", SellIn = 0, Quality = 5 };
            var updatableItem = UpdatableItemFactory.BasedOn(item);

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { updatableItem });

            Assert.Equal(3, item.Quality);
        }

        [Fact]
        public void never_decrease_items_quality_to_negative()
        {
            var item = new Item { Name = "A product", SellIn = 0, Quality = 0 };
            var updatableItem = UpdatableItemFactory.BasedOn(item);

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { updatableItem });

            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void increase_aged_brie_quality_the_older_it_gets()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 1, Quality = 0 };
            var updatableItem = UpdatableItemFactory.BasedOn(item);

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { updatableItem });

            Assert.Equal(1, item.Quality);
        }

        [Fact]
        public void never_increase_items_quality_more_than_fifty()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 };
            var updatableItem = UpdatableItemFactory.BasedOn(item);

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { updatableItem });

            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void never_change_sulfuras()
        {
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 5 };
            var updatableItem = UpdatableItemFactory.BasedOn(item);

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { updatableItem });

            Assert.Equal(5, item.Quality);
            Assert.Equal(1, item.SellIn);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(6)]
        public void increase_backstage_passes_quality_by_two_when_sell_in_is_lower_than_or_equal_to_ten(int sellIn)
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = 5 };
            var updatableItem = UpdatableItemFactory.BasedOn(item);

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { updatableItem });

            Assert.Equal(7, item.Quality);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(1)]
        public void increase_backstage_passes_quality_by_three_when_sell_in_is_lower_than_or_equal_to_five(int sellIn)
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = 5 };
            var updatableItem = UpdatableItemFactory.BasedOn(item);

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { updatableItem });

            Assert.Equal(8, item.Quality);
        }

        [Fact]
        public void drop_backstage_passes_quality_to_zero_when_sell_by_date_has_passed()
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 5 };
            var updatableItem = UpdatableItemFactory.BasedOn(item);

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { updatableItem });

            Assert.Equal(0, item.Quality);
        }
    }
}
