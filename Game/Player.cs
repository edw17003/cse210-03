using System;


namespace Unit03.Game
{
    /// <summary>
    /// <para>The person looking for the Jumper.</para>
    /// <para>
    /// The responsibility of a Player is to keep track of its location.
    /// </para>
    /// </summary>
    public class Player
    {
        private int location = 0;

        /// <summary>
        /// Constructs a new instance of Player.
        /// </summary>
        public Player()
        {
            Random random = new Random();
            location = random.Next(1001);
        }

        /// <summary>
        /// Gets the current location.
        /// </summary>
        /// <returns>The current location.</returns>
        public int GetLocation()
        {
            return location;
        }

        /// <summary>
        /// Moves to the given location.
        /// </summary>
        /// <param name="location">The given location.</param>
        public void MoveLocation(int location)
        {
            this.location = location;
        }

    }
}