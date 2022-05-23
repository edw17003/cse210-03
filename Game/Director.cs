namespace Unit03.Game
{

    public class Director
    {
        string isCorrect = "Y";
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
                isPlaying = false;
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