using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            //Calculate values for each items
            foreach(Item item in Items)
            {
                item.CalculateSellIn();
                item.CalculateQuality();
            }
        }
    }
}
