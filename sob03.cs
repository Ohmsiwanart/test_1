﻿using System.Collections.Generic;
using System;
using System.Linq;

namespace sob03
{
    class sob03
    {
        static void Main(string[] args)
        {
        
            string decide;          
            FlowerStore flowerStore = new FlowerStore();          
            do
            {
                Console.WriteLine("Select number for buy flower :");
                foreach (string i in flowerStore.flowerList)
                {
                    Console.Write((flowerStore.flowerList.IndexOf(i) + 1)+".");
                    Console.WriteLine(i);
                }
                Console.WriteLine("========================================================================");
                Console.Write("Input number: ");

                string selectFlower;
                selectFlower = Console.ReadLine();
                switch (selectFlower)
                {
                    case "1":
                        flowerStore.addToCart(flowerStore.flowerList[0]);
                        Console.WriteLine("Added " + flowerStore.flowerList[0]);
                        break;
                    case "2":
                        flowerStore.addToCart(flowerStore.flowerList[1]);
                        Console.WriteLine("Added " + flowerStore.flowerList[1]);
                        break;
                    default:
                        Console.WriteLine("Not Added to cart. found select number of flower");
                        break;
                }
                Console.WriteLine("You can stop this progress ? exit for >> exit << progress");
                Console.WriteLine("or press any key for continue");
                Console.WriteLine("=======================================================================");


                decide = Console.ReadLine();
                if (decide == "exit")
                {
                    Console.Write("Current my cart");
                    flowerStore.showCart();
                }


            } while (decide != "exit");
            
        }
    }

    class FlowerStore
    {
        public List<string> flowerList = new List<string>();
        List<string> cart = new List<string>();
        


        public FlowerStore()
        {
            flowerList.Add("Rose");
            flowerList.Add("Lotus");
            

        }
        public void addToCart(string name)
        {
            cart.Add(name);
        }

        public void showCart()
        {           
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                Console.WriteLine("My Cart :");
                foreach (string i in cart)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("all orders ={0}", cart.Count);
            }
        }




     
    }
   
}
