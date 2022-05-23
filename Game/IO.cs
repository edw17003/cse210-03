using System;

namespace Unit03.Game
{

    public class IO
    {
        private Jumper Jumper = new Jumper();

        public IO()
        {
        }

        public string ReadText()
        {
            System.Console.Write("F to remove row, T to keep row: ");
            String isCorrect = System.Console.ReadLine();
            return isCorrect;
        }

        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        public void displayParachute()
        {
            string[] parachute = Jumper.getParachute();
            foreach (string item in parachute)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}