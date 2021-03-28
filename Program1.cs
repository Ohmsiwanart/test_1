using System;

namespace testcodeweek7
{
    class Program
    {
        static void Main(string[] args)
        {
            int box1, box2, box3, num_buc, re_buc;

            Console.Write("input box in bucket 1 : ");
            box1 = int.Parse(Console.ReadLine());
            Console.Write("input box in bucket 2 : ");
            box2 = int.Parse(Console.ReadLine());
            Console.Write("input box in bucket 3 : ");
            box3 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("bucket1 = {0}  ||  bucket2 = {1}  ||  bucket 3 = {2}", box1, box2, box3);
                Console.WriteLine("---------------------------------------------------");
                Console.Write(" A ");
                Console.Write("choose your number of bucket : ");
                num_buc = int.Parse(Console.ReadLine());
                switch (num_buc)
                {
                    case 1:
                        Console.Write("How many to remove? : ");
                        re_buc = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((re_buc >= 1 && re_buc < 3)&& box1 >= 0)
                        { box1 = box1 - re_buc; }
                        else { Console.WriteLine("dafuq r u doing???"); }
                            Console.WriteLine("");
                        break;

                    case 2:
                        Console.Write("How many to remove? : ");
                        re_buc = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((re_buc >= 1 && re_buc < 3)&& box1 >= 0)
                        { box2 = box2 - re_buc; }
                        else { Console.WriteLine("dafuq r u doing???"); }
                            Console.WriteLine("");
                        break;

                    case 3:
                        Console.Write("How many to remove? : ");
                        re_buc = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if ((re_buc >= 1 && re_buc < 3)&& box1 >= 0)
                        { box3 = box3 - re_buc; }
                        else { Console.WriteLine("dafuq r u doing???"); }
                            Console.WriteLine("");
                        break;
                }
                if (box1 == 0 && box2 == 0 && box3 == 0)
                {
                    Console.WriteLine("B WON I KUY");
                }
                else
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("bucket1 = {0}  ||  bucket2 = {1}  ||  bucket 3 = {2}", box1, box2, box3);
                    Console.WriteLine("---------------------------------------------------");
                    Console.Write(" B ");
                    Console.Write("choose your number of bucket : ");
                    num_buc = int.Parse(Console.ReadLine());
                    switch (num_buc)
                    {
                        case 1:
                            Console.Write("How many to remove? : ");
                            re_buc = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if ((re_buc >= 1 && re_buc < 3)&& box1 >= 0)
                            { box1 = box1 - re_buc; }
                            else { Console.WriteLine("dafuq r u doing???"); }
                            Console.WriteLine("");
                            break;

                        case 2:
                            Console.Write("How many to remove? : ");
                            re_buc = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if ((re_buc >= 1 && re_buc < 3)&& box1 >= 0)
                            { box2 = box2 - re_buc; }
                            else { Console.WriteLine("dafuq r u doing???"); }
                            Console.WriteLine("");
                            break;

                        case 3:
                            Console.Write("How many to remove? : ");
                            re_buc = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            if ((re_buc >= 1 && re_buc < 3)&& box1 >= 0)
                            { box3 = box3 - re_buc; }
                            else { Console.WriteLine("dafuq r u doing???"); }
                            Console.WriteLine("");
                            break;
                    }
                    if (box1 == 0 && box2 == 0 && box3 == 0)
                    {
                        Console.WriteLine("A WON I NAHEE");
                    }
                }
            } while (box1 != 0 || box2 != 0 || box3 != 0);
            Console.ReadLine();
        }
    }
}
