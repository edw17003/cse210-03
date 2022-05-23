using Unit03.Game;

namespace Unit03
{
    class Program
    {
        /// Starts the program using the given arguments.
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}