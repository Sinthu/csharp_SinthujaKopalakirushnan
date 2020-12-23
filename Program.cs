using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                ItemFactory.GetItemByType("+5 Dexterity Vest", 10, 20),
                ItemFactory.GetItemByType("Aged Brie", 2, 0),
                ItemFactory.GetItemByType("Elixir of the Mongoose", 5, 7),
                ItemFactory.GetItemByType("Sulfuras, Hand of Ragnaros", 0, 80),
                ItemFactory.GetItemByType("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                ItemFactory.GetItemByType("Conjured Mana Cake", 3, 6)
            };

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    //System.Console.WriteLine(Items[j]);
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
