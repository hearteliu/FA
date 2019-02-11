using RobotsArena.Entities;
using RobotsArena.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.IO;

namespace RobotsArena
{
    /// <summary>
    /// Reads the input form the file 'input.txt' located in the root folder.
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// Reads the arena coordinates line, robot positions and movement instructions and
        /// initializes a new ArenaDto.
        /// </summary>
        /// <returns></returns>
        public ArenaDto GetArenaDto()
        {
            var path = string.Format("{0}\\{1}", Environment.CurrentDirectory, Resources.Repository.INPUT_FILENAME);

            var streamReader = new StreamReader(path);

            var inputLines = new List<string>();

            var line = string.Empty;

            while ((line = streamReader.ReadLine()) != null)
                inputLines.Add(line);

            var robots = GetRobots(inputLines.GetRange(1, inputLines.Count - 1));

            return new ArenaDto
            {
                ArenaDimensions = inputLines[0],
                Robots = robots
            };
        }

        private List<Robot> GetRobots(List<string> inputLines)
        {
            var robots = new List<Robot>();
            
            //each 2 lines pair represents robot's position and moving instructions
            for (int i = 0; i < inputLines.Count / 2; i++)
            {
                string positionLine = inputLines[2 * i];
                string movementInstructionsLine = inputLines[2 * i + 1];

                robots.Add(new Robot(positionLine, movementInstructionsLine));
            }

            return robots;
        }
    }
}
