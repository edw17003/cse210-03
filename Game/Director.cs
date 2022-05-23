namespace Unit03.Game
{

    public class Director
    {
        string isCorrect = "Y";
        private bool isPlaying = true;
        private Player Player = new Player();
        private IO IO = new IO();
        string[] parachute = {"  ___   ", " /___\\  ", " \\   /  ", "  \\ /",};


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
            isCorrect = IO.ReadText();
        }


        private void DoUpdates()
        {
            if (isCorrect == "N")
            {
                // Jumper.BreakParachute(parachute);
            }
        }


        private void DoOutputs()
        {
            IO.displayParachute();
            isPlaying = false;
        }
    }
}