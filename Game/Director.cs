namespace Unit03.Game
{

    public class Director
    {
        private bool isPlaying = true;
        private Player player = new Player();
        private Jumper jumper = new Jumper();
        private IO IO = new IO();
        private char guess;


        public Director()
        {
        }


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


        private void GetInputs()
        {
            guess = IO.ReadText();
        }


        private void DoUpdates()
        {
            if (!player.applyGuess(guess))
            {
                jumper.breakParachute();
                jumper.setJumper();
            }
            if (jumper.isDead())
            {
                IO.clearLine();
                IO.WriteText($"Unfortunately, you didn't guess the word.\nThe word was: \"{player.getWord()}\"");
                isPlaying = false;
            } else {IO.clearLine();
            }
            if (player.detectWin()) {
                isPlaying = false;
                IO.WriteText("Congratulations! You found the word!");
            }
        }


        private void DoOutputs()
        {
            IO.WriteWord(player.getOutputString());
            IO.displayParachute(jumper.getParachute());
            IO.displayJumper(jumper.getJumper());
        }
    }
}