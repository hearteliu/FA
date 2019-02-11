using System;
using System.Collections.Generic;

namespace RobotsArena.Entities
{
    /// <summary>
    /// The arena
    /// </summary>
    public class Arena
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Arena"/> class.
        /// </summary>
        /// <param name="arenaDimensions">The arena dimensions as a string.
        /// We parse this string to initialize the Width and Height of the arena.</param>
        /// <param name="robots">The robots.</param>
        /// <exception cref="Exception"></exception>
        public Arena(string arenaDimensions, List<Robot> robots)
        {
            if (robots == null || robots.Count == 0)
                throw new Exception(Resources.Exceptions.NO_ROBOTS_PROVIDED);

            Robots = robots;

            var couldNotParseArena =
            new Exception(string.Format(Resources.Arena.COULD_NOT_PARSE_ARENA_DIMENSIONS, arenaDimensions));

            if (string.IsNullOrEmpty(arenaDimensions)
                || arenaDimensions.Length < Resources.Arena.DIMENSIONS_INPUT_STRING_LENGTH)
                throw couldNotParseArena;

            int width;

            if (!int.TryParse(arenaDimensions.Substring(Resources.Arena.WIDTH_INDEX_IN_INPUT_STRING, 1), out width))
                throw couldNotParseArena;

            Width = width;

            int height;

            if (!int.TryParse(arenaDimensions.Substring(Resources.Arena.HEIGHT_INDEX_IN_INPUT_STRING, 1), out height))
                throw couldNotParseArena;

            Height = height;
        }

        /// <summary>
        /// Gets or sets the width of the arena.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the robots.
        /// </summary>
        /// <value>
        /// The robots.
        /// </value>
        public List<Robot> Robots { get; set; }
    }
}
