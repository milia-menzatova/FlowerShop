using System;
using System.Collections.Generic;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var theCustomer = new Customer("email@gmail.com", "Tamara", "Bagration");

            var rose = new Flower(1, "Rose Red", "", 10.5);
            var rose2 = new Flower(2, "Rose Red2", "", 9.5);
            List<Flower> roses = new List<Flower>();
            roses.Add(rose);
            roses.Add(rose2);
            var rosesBouquet = new Bouquet(1, "Wedding Bouquete", 100d, roses);


            // var lily = new Flower(3, "Lily", "", 5.7);
            //List<Flower> lilies = new List<Flower>();



            Console.WriteLine("Welcome to our the flower paradise!");


        }
    }

}
