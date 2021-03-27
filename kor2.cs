using System;

namespace kor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;
            Console.Write("Input number a :");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input number b :");
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;       
            do
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            } while (x != y);
             Console.Write(x);
            
        }
    }
}
