namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Jumper Jumper = new Jumper();
        private bool isPlaying = true;
        private Player Player = new Player();
        private IO IO = new IO();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Moves the Player to a new location.
        /// </summary>
        private void GetInputs()
        {
            IO.WriteText(Jumper.location.ToString());
            int location = IO.ReadNumber("\nEnter a location [1-1000]: ");
            Player.MoveLocation(location);
        }

        /// <summary>
        /// Keeps watch on where the Player is moving.
        /// </summary>
        private void DoUpdates()
        {
            Jumper.WatchPlayer(Player);
        }

        /// <summary>
        /// Provides a hint for the Player to use.
        /// </summary>
        private void DoOutputs()
        {
            string hint = Jumper.GetHint();
            IO.WriteText(hint);
            if (Jumper.IsFound())
            {
                isPlaying = false;
            }
            
        }
    }
}