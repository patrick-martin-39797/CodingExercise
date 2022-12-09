﻿using System;

namespace SampleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RunProgram();
        }

        public static void RunProgram()
        {
            Cart groceryCart = new Cart() { TypeOfCart = TypeOfCart.Grocery }; ;
            groceryCart.AddItem(new Dairy().WithDescription("Gallon of Milk").WithUnitPrice(3.50m).WithQuantity(2));
            groceryCart.AddItem(new Dairy().WithDescription("Heavy Cream").WithUnitPrice(4.59m));
            groceryCart.AddItem(new Dairy().WithDescription("Yogurt").WithUnitPrice(.59m).WithQuantity(6));
            groceryCart.AddItem(new Meat().WithWeight(3.5m).WithDescription("Hamburger").WithUnitPrice(2.96m));

            Console.WriteLine($"{groceryCart.NumberOfItems} items at a total price of {string.Format("{0:C}", groceryCart.TotalPrice())}");
            Console.WriteLine($"The {groceryCart.TypeOfCart} Cart contains the following: {groceryCart.Contents()}");
            Console.ReadLine();
        }
    }
}



