using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Models
{
    public class AgedBrie : Item
    {
        public AgedBrie(string name, int sellin, int quality) : base(name, sellin, quality) { }

        public override void CalculateQuality()
        {
            Quality = Quality + 1; //Increase in quality the older it gets
            base.CalculateQuality();
        }
    }
}
