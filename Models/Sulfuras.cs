using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Models
{
    public class Sulfuras : Item
    {
        public Sulfuras(string name, int sellin, int quality) : base(name, sellin, quality) { }

        public override void CalculateSellIn()
        {
            //Sulfuras- legendary item, never has to be sold or decreases in Quality
        }
    }
}
