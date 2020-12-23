﻿using csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public static class ItemFactory
    {
        //static method to switch between each items
        public static Item GetItemByType(string name, int sellIn, int quality)
        {
            switch(name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    return new Sulfuras(name, sellIn, quality);
                case "Aged Brie":
                    return new AgedBrie(name, sellIn, quality);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePasses(name, sellIn, quality);
                case "Conjured Mana Cake":
                    return new Conjured(name, sellIn, quality);
                default:
                    return new RegularItem(name, sellIn, quality);
            }
        }

    }
}
