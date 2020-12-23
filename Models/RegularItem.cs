using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Models
{
    public class RegularItem : Item
    {
        public RegularItem(string name, int sellin, int quality) : base(name, sellin, quality) { }

        public override void CalculateQuality()
        {
            Quality = Quality - 2; //normal item quality decreases by 2
            base.CalculateQuality();
        }

    }
}
