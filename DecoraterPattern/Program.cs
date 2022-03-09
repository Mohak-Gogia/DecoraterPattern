using DecoraterPattern.Beverages;
using DecoraterPattern.Condiments;
using System;

namespace DecoraterPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            Beverage bev = new Espresso();
            bev = new Mocha(bev);   // wrap it up with mocha
            bev = new Soy(bev);     // wrap it up with soy
            Console.WriteLine("Coffee : " + bev.getDescription() + " and cost = $" + bev.cost());

            Beverage bev2 = new DarkRoast();
            bev2 = new Whip(bev2);      
            bev2 = new Whip(bev2);     // wrap it up with double whip
            Console.WriteLine("Coffee : " + bev2.getDescription() + " and cost = $" + bev2.cost());

            Beverage bev3 = new Decaf();
            bev3 = new Mocha(bev3);      // wrap it up with mocha
            bev3 = new Whip(bev3);      // wrap it up with whip
            bev3 = new Soy(bev3);      // wrap it up with soy
            Console.WriteLine("Coffee : " + bev3.getDescription() + " and cost = $" + bev3.cost());
        }
    }
}
