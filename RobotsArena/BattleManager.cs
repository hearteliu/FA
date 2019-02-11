using RobotsArena.Entities;
using System;

namespace RobotsArena
{
    /// <summary>
    /// Manages the battle: initializes Arena, loops through robots, engages them, displays the result
    /// </summary>
    public class BattleManager
    {
        private Arena arena;

        public BattleManager()
        {
            arena = new ArenaManager().InitializeArena();
        }

        /// <summary>
        /// Starts the battle by looping through the robots and engaging each of them
        /// for each of the corresponding movement instructions.
        /// </summary>
        public void StartBattle()
        {
            foreach (var robot in arena.Robots)
            {
                foreach (var instruction in robot.MovementInstructions)
                {
                    if (robot.IsWreck)
                        continue;

                    robot.IsWreck = new CollisionDetector(arena.Width, arena.Height).IsCollision(robot.Position);

                    robot.Engage(instruction);
                }

                // robot's position gets updated after each engagement in the battle.
                // after engagement we display robot's current position on the screen as output
                Console.WriteLine(string.Format("{0} {1} {2} {3}",
                    robot.Position.X,
                    robot.Position.Y,
                    robot.Position.Orientation,
                    robot.IsWreck ? Resources.Position.IS_WRECK : string.Empty));
            }
        }
    }
}