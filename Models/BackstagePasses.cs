using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Models
{
    public class BackstagePasses : Item
    {
        public BackstagePasses (string name, int sellin, int quality) : base(name, sellin, quality) { }

        public override void CalculateQuality()
        {
            if (SellIn < 0) { Quality = 0; }
            else if (SellIn <= 5) { Quality = Quality + 3; } //Quality increases by 3 when there are 5 days or less
            else if (SellIn <= 10) { Quality = Quality + 2; } //Quality increases by 2 when there are 10 days or less
            else { Quality = Quality + 1; }

            base.CalculateQuality();
        }
    }
}
