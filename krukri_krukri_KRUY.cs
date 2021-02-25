using System;

namespace nahi
{
    class Program
    {
        static void Main(string[] args)
        {
            string _Agency;
            int _PASS;


            Console.WriteLine("INPUT YOUR SIX NUMBER PASSWORD :");
            _PASS = int.Parse(Console.ReadLine());
            if ((_PASS <= 100000) || (_PASS > 1000000))
            {
                do
                {
                    Console.WriteLine("IT WRONG TRY IT AGAIN!! :");
                    _PASS = int.Parse(Console.ReadLine());

                } while ((_PASS! >= 999999) || (_PASS! < 10000));
            }
            ///////////////////////////////////
            ///////////////////////////////////

            Console.WriteLine("INSERT YOUR AGNECY :");
            _Agency = Console.ReadLine();
            if (_Agency != "FBI" && _Agency != "CIA" && _Agency != "NSA")
            {
                do
                {
                    Console.WriteLine("IT WRONG TRY IT AGAIN!! :");
                    _Agency = Console.ReadLine();

                } while (_Agency != "FBI" && _Agency != "CIA" && _Agency != "NSA");
            }
            ///////////////////////////////////
            ///////////////////////////////////

            int _one   = _PASS % 10;
            int _ten   = _PASS % 100;
            int _hr    = _PASS % 1000;
            int _ts    = _PASS % 10000;
            int _tents = _PASS % 100000;
            int _hrts  = _PASS % 1000000;

            if (_Agency == "CIA")
            {
                if ((_ts >= 6000) && (_ts != 8000))
                {
                    if ((_ten != 10) && (_ten != 30) && (_ten != 50))
                    {
                        if (_one % 3 == 0)
                        {
                            Console.WriteLine("LOGIN SUCCESS!. WELCOME TO MDT");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("hmmm are u sure?");
                }
            }


            else if (_Agency == "FBI")
            {
                if ( (_hrts >= 400000) && (_hrts <= 700000) )
                {
                    if (_tents % 20000 >= 10000 && _tents% 20000 <20000 )
                    {
                        if ((_hr / 100) % 2==0 && ((_hr / 100) != 6))
                        {
                            Console.WriteLine("LOGIN SUCCESS!. WELCOME TO MDT");
                        }
                        else
                        {
                            Console.WriteLine("1hmmm are u sure?");
                        }
                    }
                    else
                    {
                        Console.WriteLine("2hmmm are u sure?");
                    }
                }
                else
                {
                    Console.WriteLine("3hmmm are u sure?");
                }
            }


            if (_Agency == "NSA")
            {
                if ((_hrts >= 700000) && (_hrts < 800000) || (_tents >= 70000) && (_hrts < 80000) || (_ts >= 7000) && (_hrts < 8000) || (_hr >= 700) && (_hrts < 800) || (_ten >= 70) && (_hrts < 80) || (_one >= 7) && (_hrts < 8))
                {                                 
                        if ((_hr / 100) % 3==0 && ((_hr / 100) % 2 !=0))
                        {                      
                            if (_one == 1 || _one ==2 || _one == 3 || _one == 5 || _one == 6)
                            {
                            Console.WriteLine("LOGIN SUCCESS!. WELCOME TO MDT");
                            }
                            else
                            Console.WriteLine("3hmmm are u sure?");                      
                        } 
                        else
                        Console.WriteLine("2hmmm are u sure?");
                }
                else
                {
                    Console.WriteLine("1hmmm are u sure?");
                }
            }
            
            Console.ReadLine();
        }
    }
}
