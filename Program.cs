using System;

namespace final_test
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int size = int.Parse(Console.ReadLine());
             double[] answer = new double[size] ;    
             for (int i = 0; i < answer.Length; i++)
             {
                 answer[i] = double.Parse(Console.ReadLine());
                 Console.WriteLine(answer.Length);
             }*/

            /*string inputstring = Console.ReadLine();
            if (inputstring == "FindMax")
            {
                int FindMax = (Math.Max(5, 10));
            }
            else if (inputstring == "FindMin")
            {
                int FindMin = (Math.Min());}
            */
            Console.Write("input size : ");
            int size = int.Parse(Console.ReadLine());
            int[] answer = new int[size]; 
            for (int i = 0; i < size; i++)
            {
                Console.Write("input number : ");
                answer[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            ////////////////////////////////////////////////
            
            Console.Write("VALORANT KAK sort : ");
            int temp;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (answer[i] > answer[j])
                    {

                        temp = answer[i];
                        answer[i] = answer[j];
                        answer[j] = temp;
                    }
                }              
            }
            foreach (int cs in answer)
            {
                Console.Write(cs + " ");
            }
            //////////////////////////////////////
            
            Console.WriteLine(" ");

            Console.Write("eiei sort : ");
            foreach (int cs in answer)
            {
                Array.Sort(answer);
                Console.Write(cs + " ");
            }

            Console.WriteLine(" ");

            Console.Write("sort ru sort : ");
            Array.Sort<int>(answer, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
            {
                Array.Reverse(answer); 
            }
            foreach (int go in answer)
            {
                Array.Sort(answer);
                Console.Write(go + " ");
            }

            Console.WriteLine(" ");

            Console.Write("BB sort : ");
            Array.Sort<int>(answer, delegate (int m, int n)
            { return n - m; });
            foreach (int ggez in answer)
            {
                Array.Sort(answer);
                Console.Write(ggez + " ");
            }
            Console.ReadLine();
        }
    }
}
