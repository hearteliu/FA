namespace RobotsArena
{
    /// <summary>
    /// Used to store constants
    /// </summary>
    public class Resources
    {
        public partial class Exceptions
        {
            public const string COULD_NOT_PARSE_POSITION = "Could not parse position: {0}";

            public const string NO_ROBOTS_PROVIDED = "No robots provided.";

            public const string COULD_NOT_INITIALIZE_ARENA = "Could not initialize arena.";

            public const string INVALID_MOVE = "Invalid move.";
        }

        public partial class Position
        {
            public const int POSITION_INPUT_STRING_LENGTH = 5;

            public const int X_INDEX_IN_INPUT_STRING = 0;

            public const int Y_INDEX_IN_INPUT_STRING = 2;

            public const int ORIENTATION_INDEX_IN_INPUT_STRING = 4;

            public const string OUTPUT_LINE_TEMPLATE = "{0} {1} {2} {4} ";

            public const string IS_WRECK = "Wreck";
        }

        public partial class Arena
        {
            public const string COULD_NOT_PARSE_ARENA_DIMENSIONS = "Could not parse arena dimensions: {0}";

            public const int WIDTH_INDEX_IN_INPUT_STRING = 0;

            public const int HEIGHT_INDEX_IN_INPUT_STRING = 2;

            public const int DIMENSIONS_INPUT_STRING_LENGTH = 3;
        }

        public partial class Repository
        {
            public const string INPUT_FILENAME = "input.txt";
        }
    }
}
