﻿using System;

namespace close_friend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input mode :");
            string m = Console.ReadLine();
            Console.Write("input time :");
            double t = double.Parse(Console.ReadLine());
            Console.Write("input price :");
            double p = double.Parse(Console.ReadLine());
            if ((m == "time") && (t > 0))
            {
                Console.Write("{0}, {1}", t, p = Math.Pow(t - 1, 2));
            }
            else if (t < 0)
            {
                Console.Write("Invalid mouse position");
            }
            else if (m == "price")
            {
                Console.Write("{0}, {1}", t = Math.Sqrt(p) + 1, p);
            }
            else if (m != "time" || m != "price")
            {
                Console.Write("Invalid mode");
            }

            Console.ReadLine();
        }
    }
    
}