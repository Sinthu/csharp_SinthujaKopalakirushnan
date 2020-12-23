using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Models
{
    public class Conjured : Item
    {
        public Conjured(string name, int sellin, int quality) : base(name, sellin, quality) { }

        public override void CalculateQuality()
        {
            Quality = Quality - 4; //Quality decreases twice as fast as normal items, normal items decreases by 2
            base.CalculateQuality();
        }
    }
}
