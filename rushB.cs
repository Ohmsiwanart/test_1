using System;

namespace CYKA_BLYAT
{
    class rushB
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("U CAN'T SELECT THIS GAME BECAUSE U HAVE A MANY OF GAME? I CAN CHOOSE FOR U");
            Console.WriteLine("---------------------------------------------");
            Console.Write("HOW MANY GAME THAT U WANNA TO PLAY? : ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");
            string[] answer = new string[size]; //หาวิธีทําโค๊ดใส่แต่ตัวเลขอย่างเดียวไม่ได้

            for (int i = 0; i < answer.Length; i++,size--)
            {
                Console.WriteLine("U HAD ["+ size + "] LIST ");
                Console.Write("INPUT THESE GAME NAME IN HERE : ");
                answer[i] = Console.ReadLine();
                Console.WriteLine("");
            }

            Random rand = new Random();
            int index = rand.Next(answer.Length);
            Console.WriteLine($"OK U SHOULD PLAY.... {answer[index]}. LET'S GOOOO!!");
        }          
    }
}

    