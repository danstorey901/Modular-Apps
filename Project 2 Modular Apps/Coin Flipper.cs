using System;

class CoinFlipper
{
    public void Start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Press your Luck!");
            Console.WriteLine("How many coins do you want to flip?");
            string input;
            //tests for input to make sure its valid
            while (true)
            {
                input = Console.ReadLine();
                if (input == " e ")
                {
                    break;
                }

                try
                {
                    int.Parse(input);
                    break;
                }

                catch (Exception e)
                {
                    Console.WriteLine("Exception");
                    Console.WriteLine(e.Message);
                }

            
            }

            //see if user wants to exit
            if (input == "e")
            {
                Console.WriteLine("Thanks for Playing!");
                Console.ReadLine();
                break;
            }

            int num = int.Parse(input); // try catch
            int heads = 0;
            int tails = 0;
            Random R = new Random();

            for (int x = 0; x < num; x++)
            {
                int y = R.Next(0, 2);
                if (y == 0)
                {
                    heads++;
                    Console.WriteLine("Heads");
                }
                if (y == 1)
                {
                    tails++;
                    Console.WriteLine("Tails");
                }
            }
            Console.WriteLine("We flipped: " + num + " coins.");
            Console.WriteLine(heads + " were heads.");
            Console.WriteLine(tails + " were tails.");
            Console.ReadLine();
        }

    }
}