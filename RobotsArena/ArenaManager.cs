using RobotsArena.Entities;
using System;

namespace RobotsArena
{
    /// <summary>
    /// Used to get the arena Dto from the repository and initialize a new instance of Arena class.
    /// </summary>
    public class ArenaManager
    {
        /// <summary>
        /// Initializes the arena.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Arena InitializeArena()
        {
            var repository = new Repository();

            var arenaDto = repository.GetArenaDto();

            if (arenaDto == null)
                throw new Exception(Resources.Exceptions.COULD_NOT_INITIALIZE_ARENA);

            return new Arena(arenaDto.ArenaDimensions, arenaDto.Robots);
        }
    }
}
