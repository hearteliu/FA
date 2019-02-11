
namespace RobotsArena.Entities
{
    /// <summary>
    /// Used to detect if the robot hit the wall.
    /// </summary>
    public class CollisionDetector
    {
        private int arenaWidth;

        private int arenaHeight;

        public CollisionDetector(int arenaWidth, int arenaHeight)
        {
            this.arenaWidth = arenaWidth;
            this.arenaHeight = arenaHeight;
        }

        /// <summary>
        /// Determines whether the robot hit the wall or not.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns>
        ///   <c>true</c> if the robot hit the wall; otherwise, <c>false</c>.
        /// </returns>
        public bool IsCollision(Position position)
        {
            if (position == null)
                return true;

            return position.X > arenaWidth - 1 
                   || position.X < 0
                   || position.Y > arenaHeight - 1
                   || position.Y < 0;
        }
    }
}
