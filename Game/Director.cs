namespace Unit03.Game
{

    public class Director
    {
        // Variable declarations
        private bool isPlaying = true;
        private Player player = new Player();
        private Jumper jumper = new Jumper();
        private IO IO = new IO();
        private char guess;

        public Director()
        {
        }

        // Runs the game loop
        public void StartGame()
        {
            IO.clearLine();
            DoOutputs();
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        // Calls ReadText from the IO class (Prompts user for letter guess)
        private void GetInputs()
        {
            guess = IO.ReadText();
        }

        private void DoUpdates()
        {
            // If the guess is false, breaks the parachute and displays the jumper
            if (!player.applyGuess(guess))
            {
                jumper.breakParachute();
                jumper.setJumper();
            }
            // If the parachute is completely broken, ends the game and displays game-over message
            if (jumper.isDead())
            {
                IO.clearLine();
                IO.WriteText($"Unfortunately, you didn't guess the word.\nThe word was: \"{player.getWord()}\"");
                isPlaying = false;
            } else {IO.clearLine();
            }
            // If the word has been guessed, ends the game and game-win message
            if (player.detectWin()) {
                isPlaying = false;
                IO.WriteText("Congratulations! You found the word!");
            }
        }

        // Calls methods in the IO class to display current game state
        private void DoOutputs()
        {
            IO.WriteWord(player.getOutputString());
            IO.displayParachute(jumper.getParachute());
            IO.displayJumper(jumper.getJumper());
        }
    }
}