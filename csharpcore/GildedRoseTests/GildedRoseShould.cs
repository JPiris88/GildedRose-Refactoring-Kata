using GildedRose;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseShould
    {
        [Fact]
        public void decrease_items_quality_by_two_when_sell_by_date_has_passed()
        {
            var item = new StandardItem(name: new ItemName("A product"), sellIn: new ItemSellIn(0), quality: new ItemQuality(5));

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { item });

            Assert.Equal(3, item.Quality.Value);
        }

        [Fact]
        public void never_decrease_items_quality_to_negative()
        {
            var item = new StandardItem(name: new ItemName("A product"), sellIn: new ItemSellIn(0), quality: new ItemQuality(0));

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { item });

            Assert.Equal(0, item.Quality.Value);
        }

        [Fact]
        public void increase_aged_brie_quality_the_older_it_gets()
        {
            var item = new AgedBrie(sellIn: new ItemSellIn(1), quality: new ItemQuality(0));

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { item });

            Assert.Equal(1, item.Quality.Value);
        }

        [Fact]
        public void never_increase_items_quality_more_than_fifty()
        {
            var item = new AgedBrie(sellIn: new ItemSellIn(5), quality: new ItemQuality(50));

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { item });

            Assert.Equal(50, item.Quality.Value);
        }

        [Fact]
        public void never_change_sulfuras()
        {
            var item = new Sulfuras(sellIn: new ItemSellIn(1), quality: new ItemQuality(5));

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { item });

            Assert.Equal(5, item.Quality.Value);
            Assert.Equal(1, item.SellIn.Value);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(6)]
        public void increase_backstage_passes_quality_by_two_when_sell_in_is_lower_than_or_equal_to_ten(int sellIn)
        {
            var item = new BackstagePasses(sellIn: new ItemSellIn(sellIn), quality: new ItemQuality(5));

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { item });

            Assert.Equal(7, item.Quality.Value);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(1)]
        public void increase_backstage_passes_quality_by_three_when_sell_in_is_lower_than_or_equal_to_five(int sellIn)
        {
            var item = new BackstagePasses(sellIn: new ItemSellIn(sellIn), quality: new ItemQuality(5));

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { item });

            Assert.Equal(8, item.Quality.Value);
        }

        [Fact]
        public void drop_backstage_passes_quality_to_zero_when_sell_by_date_has_passed()
        {
            var item = new BackstagePasses(sellIn: new ItemSellIn(0), quality: new ItemQuality(5));

            var gildedRose = new GildedRoseKata.GildedRose();

            gildedRose.UpdateQuality(new[] { item });

            Assert.Equal(0, item.Quality.Value);
        }
    }
}
