using System;

namespace Unit03.Game
{

    public class IO
    {

        public IO()
        {
        }


        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}