namespace Unit03.Game
{

    public class Director
    {
        private Jumper Jumper = new Jumper();
        private bool isPlaying = true;
        private Player Player = new Player();
        private IO IO = new IO();


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

        }


        private void DoUpdates()
        {

        }


        private void DoOutputs()
        {
            
        }
    }
}