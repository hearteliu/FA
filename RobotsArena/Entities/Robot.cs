using RobotsArena.Entities;
using RobotsArena.Entities.Enums;
using System;

namespace RobotsArena.Entities
{
    /// <summary>
    /// The Robot.
    /// </summary>
    public class Robot
    {
        public Robot(string position, string movementInstructions)
        {
            Position = new Position(position);

            MovementInstructions = movementInstructions;
        }

        /// <summary>
        /// Gets or sets the current position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public Position Position { get; set; }

        /// <summary>
        /// Gets or sets the movement instructions.
        /// They are passed in from the input file through the ArenaDto.
        /// </summary>
        /// <value>
        /// The movement instructions.
        /// </value>
        public string MovementInstructions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this robot is wreck as result
        /// of hitting a wall.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this this is wreck; otherwise, <c>false</c>.
        /// </value>
        public bool IsWreck { get; set; }

        /// <summary>
        /// Engages the robot based on the specified instruction.
        /// If the instruction is 'L' or 'R' we just call the ChangeHeadingLeft()
        /// and ChangeHeadingRight() methods which modify the 'Orientation' property
        /// of this instance's Position.
        /// </summary>
        /// <param name="instruction">The instruction.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Position Engage(char instruction)
        {
            switch (instruction)
            {
                case Instrucitions.LEFT:
                    {
                        ChangeHeadingLeft();
                        break;
                    }
                case Instrucitions.RIGHT:
                    {
                        ChangeHeadingRight();
                        break;
                    }
                case Instrucitions.MOVE:
                    {
                        Move();
                        break;
                    }
                default:
                    throw new Exception(Resources.Exceptions.INVALID_MOVE);
            }

            return Position;
        }

        /// <summary>
        /// Changes the heading to the left.
        /// </summary>
        private void ChangeHeadingLeft()
        {
            switch (Position.Orientation)
            {
                case HeadingDirections.NORTH:
                    {
                        Position.Orientation = HeadingDirections.WEST;
                        break;
                    }
                case HeadingDirections.EAST:
                    {
                        Position.Orientation = HeadingDirections.NORTH;
                        break;
                    }
                case HeadingDirections.SOUTH:
                    {
                        Position.Orientation = HeadingDirections.EAST;
                        break;
                    }
                case HeadingDirections.WEST:
                    {
                        Position.Orientation = HeadingDirections.SOUTH;
                        break;
                    }
            }
        }

        /// <summary>
        /// Changes the heading to the right.
        /// </summary>
        private void ChangeHeadingRight()
        {
            switch (Position.Orientation)
            {
                case HeadingDirections.NORTH:
                    {
                        Position.Orientation = HeadingDirections.EAST;
                        break;
                    }
                case HeadingDirections.EAST:
                    {
                        Position.Orientation = HeadingDirections.SOUTH;
                        break;
                    }
                case HeadingDirections.SOUTH:
                    {
                        Position.Orientation = HeadingDirections.WEST;
                        break;
                    }
                case HeadingDirections.WEST:
                    {
                        Position.Orientation = HeadingDirections.NORTH;
                        break;
                    }
            }
        }

        /// <summary>
        /// Modifies robot's position based on current orientation.
        /// </summary>
        private void Move()
        {
            switch (Position.Orientation)
            {
                case HeadingDirections.NORTH:
                    {
                        Position.Y++;

                        break;
                    }
                case HeadingDirections.SOUTH:
                    {
                        Position.Y--;

                        break;
                    }
                case HeadingDirections.EAST:
                    {
                        Position.X++;

                        break;
                    }
                case HeadingDirections.WEST:
                    {
                        Position.X--;

                        break;
                    }
            }
        }
    }
}
