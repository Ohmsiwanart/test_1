using System;
using System.Collections.Generic;
using System.Text;
enum Menu
{
    play=1,
    exit
}

namespace sobja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME");
            Console.WriteLine("1. play");
            Console.WriteLine("2. exit");
            InputMenuFromKeyboard();
        }

        static void InputMenuFromKeyboard()
        {
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.play)
            {
                playhangman();
            }
            else
            {
                
            }
        }

        static void playhangman()
        {
            string[] listwords = new string[3];
            listwords[0] = "tenis";
            listwords[1] = "fottball";
            listwords[2] = "badminton";

            Random randGen = new Random();
            int idx = randGen.Next(0, 2);
            string mysteryWord = listwords[idx];
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");

            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '_';

            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
            }
        }
    }
}


        

