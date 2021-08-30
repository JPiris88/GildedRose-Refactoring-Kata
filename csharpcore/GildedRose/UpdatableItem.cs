namespace GildedRoseKata
{
    public class UpdatableItem
    {
        private const string AGED_BRIE = "Aged Brie";
        private const string BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        private const int MAXIMUM_QUALITY = 50;
        private const int MINIMUM_QUALITY = 0;
        private const int DOUBLE_BACKSTAGE_PASSES_QUALITY_WHEN_SELL_IN_LOWER_THAN = 11;
        private const int TRIPLE_BACKSTAGE_PASSES_QUALITY_WHEN_SELL_IN_LOWER_THAN = 6;
        private const int DECREASE_DEFAULT_ITEM_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN = 0;

        private readonly Item _item;

        public UpdatableItem(Item item)
        {
            _item = item;
        }

        public void Update()
        {
            switch (_item.Name)
            {
                case AGED_BRIE:
                    DecreaseSellIn();
                    IncreaseAgedBrieQuality();
                    break;
                case BACKSTAGE_PASSES:
                    IncreaseBackstagePassesQuality();
                    DecreaseSellIn();
                    DropBackstagePassesQualityToZero();
                    break;
                case SULFURAS:
                    break;
                default:
                    DecreaseSellIn();
                    DecreaseDefaultItemQuality();
                    break;
            }
        }

        private void DropBackstagePassesQualityToZero()
        {
            if (_item.SellIn < DECREASE_DEFAULT_ITEM_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN)
            {
                DropQualityToZero();
            }
        }

        private void DecreaseDefaultItemQuality()
        {
            DecreaseQuality();

            if (_item.SellIn < DECREASE_DEFAULT_ITEM_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN)
            {
                DecreaseQuality();
            }
        }

        private void IncreaseBackstagePassesQuality()
        {
            IncreaseQuality();

            if (_item.SellIn < DOUBLE_BACKSTAGE_PASSES_QUALITY_WHEN_SELL_IN_LOWER_THAN)
            {
                IncreaseQuality();
            }

            if (_item.SellIn < TRIPLE_BACKSTAGE_PASSES_QUALITY_WHEN_SELL_IN_LOWER_THAN)
            {
                IncreaseQuality();
            }
        }

        private void IncreaseAgedBrieQuality()
        {
            IncreaseQuality();

            if (_item.SellIn < DECREASE_DEFAULT_ITEM_QUALITY_BY_TWO_WHEN_SELL_IN_LOWER_THAN)
            {
                IncreaseQuality();
            }
        }

        private void DropQualityToZero()
        {
            _item.Quality = 0;
        }

        private void DecreaseSellIn()
        {
            _item.SellIn--;
        }

        private void DecreaseQuality()
        {
            if (_item.Quality > MINIMUM_QUALITY)
            {
                _item.Quality--;
            }
        }

        private void IncreaseQuality()
        {
            if (_item.Quality < MAXIMUM_QUALITY)
            {
                _item.Quality++;
            }
        }
    }
}
