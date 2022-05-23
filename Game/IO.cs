using System;

namespace Unit03.Game
{

    public class IO
    {
        public IO()
        {
        }

        public char ReadText()
        {
            System.Console.Write("Guess a letter: ");
            string isCorrect = System.Console.ReadLine().ToLower();
            return isCorrect[0];
        }

        public void WriteText(string text)
        {
            Console.WriteLine(text);

        }

        public void WriteWord(char[] word)
        {
            foreach (char i in word)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void displayParachute(string[] parachute)
        {
            foreach (string item in parachute)
            {
                System.Console.WriteLine(item);
            }
        }

        public void displayJumper(string[] jumper)
        {
            foreach (string item in jumper)
            {
                System.Console.WriteLine(item);
            }
        }
        public void clearLine() {
            Console.Clear();
        }
    }
}