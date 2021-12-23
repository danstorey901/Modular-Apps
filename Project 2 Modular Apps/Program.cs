using System;

namespace Project_2_Modular_Apps
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("What module would you like to use?");
                Console.WriteLine("1. Coin Flip");
                Console.WriteLine("2. Keylogger");
                Console.WriteLine("3. Prime Number Calculator");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CoinFlipper a = new CoinFlipper();
                        a.Start();
                        break;

                    case "2":
                        KeyLogger b = new KeyLogger();
                        b.Start();
                        break;

                    case "3":
                        PrimeNumCal c = new PrimeNumCal();
                        c.Start();
                        break;


                    default:

                        break;

                }

                Console.WriteLine("End of Loop");
                Console.ReadLine();
                Console.Clear();



            }

        }
    }
}
