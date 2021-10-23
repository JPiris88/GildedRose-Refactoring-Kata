namespace GildedRoseKata
{
    public abstract class UpdatableItem
    {
        private const int MAXIMUM_QUALITY = 50;
        private const int MINIMUM_QUALITY = 0;

        private readonly Item _item;

        public UpdatableItem(Item item)
        {
            _item = item;
        }

        public abstract void Update();

        protected int SellIn() => _item.SellIn;

        protected void DropQualityToZero()
        {
            _item.Quality = 0;
        }

        protected void DecreaseSellIn()
        {
            _item.SellIn--;
        }

        protected void DecreaseQuality()
        {
            if (_item.Quality > MINIMUM_QUALITY)
            {
                _item.Quality--;
            }
        }

        protected void IncreaseQuality()
        {
            if (_item.Quality < MAXIMUM_QUALITY)
            {
                _item.Quality++;
            }
        }
    }
}
