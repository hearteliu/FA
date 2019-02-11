using System;

namespace RobotsArena.Entities
{
    /// <summary>
    /// Used to parse and represent robot's position.
    /// The constructor gets robot position as a string as specified in the input
    /// ans parses it into the actual coordinates which are used to initialize the
    /// properties of this class.
    /// </summary>
    public class Position
    {
        public Position(string position)
        {
            var couldNotParsePosition =
                new Exception(string.Format(Resources.Exceptions.COULD_NOT_PARSE_POSITION, position));

            if (string.IsNullOrEmpty(position)
                || position.Length < Resources.Position.POSITION_INPUT_STRING_LENGTH)
                throw couldNotParsePosition;

            int x;

            if (!int.TryParse(position.Substring(Resources.Position.X_INDEX_IN_INPUT_STRING, 1), out x))
                throw couldNotParsePosition;

            X = x;

            int y;


            if (!int.TryParse(position.Substring(Resources.Position.Y_INDEX_IN_INPUT_STRING, 1), out y))
                throw couldNotParsePosition;

            Y = y;

            char orientation;

            if (!char.TryParse(position.Substring(Resources.Position.ORIENTATION_INDEX_IN_INPUT_STRING, 1), out orientation))
                throw new Exception(string.Format(Resources.Exceptions.COULD_NOT_PARSE_POSITION));

            Orientation = orientation;
        }

        /// <summary>
        /// Gets or sets the X coordinate.
        /// </summary>
        /// <value>
        /// The X coordinate.
        /// </value>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y coordinate.
        /// </summary>
        /// <value>
        /// The Y.
        /// </value>
        public int Y { get; set; }

        /// <summary>
        /// Gets or sets the orientation. Possible values: 'N', 'E', 'S', 'W'
        /// </summary>
        /// <value>
        /// The orientation.
        /// </value>
        public char Orientation { get; set; }
    }
}
