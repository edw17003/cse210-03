using System;

namespace Unit03.Game
{
    // The IO class is responsible for all input/output that takes place in the terminal
    public class IO
    {
        public IO()
        {
        } 
        // Get a letter guess from the user
        public char ReadText()
        {
            System.Console.Write("Guess a letter: ");
            string isCorrect = System.Console.ReadLine().ToLower();
            return isCorrect[0];
        }
        // Writes any text passed to it to the terminal
        public void WriteText(string text)
        {
            Console.WriteLine(text);

        }
        // Display the current state of the word to be guessed
        public void WriteWord(char[] word)
        {
            foreach (char i in word)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // Display the current state of the well-made parachute
        public void displayParachute(string[] parachute)
        {
            foreach (string item in parachute)
            {
                System.Console.WriteLine(item);
            }
        }
        // Display the current person sprite (and ground)
        public void displayJumper(string[] jumper)
        {
            foreach (string item in jumper)
            {
                System.Console.WriteLine(item);
            }
        }
        // Clear the terminal (used after each iteration)
        public void clearLine() {
            Console.Clear();
        }
    }
}