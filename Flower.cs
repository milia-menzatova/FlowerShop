namespace FlowerShop
{
    public class Flower
    {
        public long ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }

        public Flower(long ID, string Name, string Description, double Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        }



    }
}