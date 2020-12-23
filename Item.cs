namespace csharp
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        protected Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        //Common sellin value declaration
        public virtual void CalculateSellIn()
        {
            SellIn = SellIn - 1;
        }

        //Common quality values declaration
        public virtual void CalculateQuality()
        {
            if (Quality < 0) { Quality = 0; }
            else if(Quality == 80) { Quality = 80; } //Quality of Sulfuras - 80 
            else if (Quality > 50) { Quality = 50; } //Quality cannot be above 50
        }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }  
    }
}
