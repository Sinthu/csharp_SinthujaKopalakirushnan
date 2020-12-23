using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { ItemFactory.GetItemByType ("Aged Brie", 10, 10) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(9, Items[0].SellIn);
            Assert.AreEqual(11, Items[0].Quality);
        }

        [Test]
        public void TestCodeOutput()
        {
            List<Item> items = new List<Item>()
            {
                ItemFactory.GetItemByType("+5 Dexterity Vest", 10, 20),
                ItemFactory.GetItemByType("Aged Brie", 2, 0),
                ItemFactory.GetItemByType("Elixir of the Mongoose", 5, 7),
                ItemFactory.GetItemByType("Sulfuras, Hand of Ragnaros", 0, 80),
                ItemFactory.GetItemByType("Backstage passes to a TAFKAL80ETC concert",15,20),
                ItemFactory.GetItemByType("Conjured Mana Cake", 3, 6)
            };

            var app = new GildedRose(items);
            app.UpdateQuality();

            var expectedOutput = new List<Item>()
            {
                ItemFactory.GetItemByType("+5 Dexterity Vest", 9, 18),
                ItemFactory.GetItemByType("Aged Brie", 1, 1),
                ItemFactory.GetItemByType("Elixir of the Mongoose", 4, 6),
                ItemFactory.GetItemByType("Sulfuras, Hand of Ragnaros", 0, 80),
                ItemFactory.GetItemByType("Backstage passes to a TAFKAL80ETC concert",14,21),
                ItemFactory.GetItemByType("Conjured Mana Cake", 2, 5)
            };

            Assert.AreEqual(expectedOutput[0], items[0]);
            Assert.AreEqual(expectedOutput[1], items[1]);
            Assert.AreEqual(expectedOutput[2], items[2]);
            Assert.AreEqual(expectedOutput[3], items[3]);
            Assert.AreEqual(expectedOutput[4], items[4]);
            Assert.AreEqual(expectedOutput[5], items[5]);
        }

        //Sulfuras, a legendary item, never to be sold or decreases in quality.
        [Test]
        public void Salfuras_NotChangeQuality()
        {
            var items = new List<Item>() { ItemFactory.GetItemByType("Sulfuras, Hand of Ragnaros", 0, 80) };
            var app = new GildedRose(items);
            app.UpdateQuality();

            var expectedOutput = new List<Item>() { ItemFactory.GetItemByType("Sulfuras, Hand of Ragnaros", 0, 80) };
            Assert.AreEqual(expectedOutput[0], items[0]);
        }

        //AgedBrie - increase in quality by date
        [Test]
        public void AgedBrie_QualityIncrease()
        {
            var items = new List<Item>() { ItemFactory.GetItemByType("Aged Brie", 2, 0) };
            var app = new GildedRose(items);
            app.UpdateQuality();

            var expectedOutput = new List<Item>() { ItemFactory.GetItemByType("Aged Brie", 1, 1) };
            Assert.AreEqual(expectedOutput[0], items[0]);
        }

        //BackstagePasses - Increase in quality by 2, If <=10 Days
        [Test]
        public void BackstagePasses_IncreaseInQualityBy2()
        {
            List<Item> Items = new List<Item>() { ItemFactory.GetItemByType("Backstage passes to a TAFKAL80ETC concert", 10, 20) };
            var app = new GildedRose(Items);
            app.UpdateQuality();

            List<Item> expectedOutput = new List<Item>() { ItemFactory.GetItemByType("Backstage passes to a TAFKAL80ETC concert", 9, 22) };
            Assert.AreEqual(expectedOutput[0], Items[0]);

        }
    }
}
