using System;
using System.IO;

namespace Project_2_Modular_Apps
{
    class KeyLogger
    {
        public void Start()
        {
            Console.WriteLine("Keylogger Started");

            string text = "";
            

            while (true)
            {
                char Keystroke = Console.ReadKey().KeyChar;

                text += Keystroke;


                if (Keystroke == '`')
                {
                    //save the text to a txt file
                    string Filepath = @"C:\Users\angry\GREG\G.txt";
                    File.WriteAllText(Filepath, text);

                    break;
                }
            }

        }
       
    }
}
