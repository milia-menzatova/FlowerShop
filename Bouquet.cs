using System.Collections.Generic;

namespace FlowerShop
{
    public class Bouquet
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        private List<Flower> Flowers;
        public double Price { get; private set; }

        public Bouquet(long Id, string Name, double Price, List<Flower> Flowers)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Flowers = Flowers;
        }
    }
}