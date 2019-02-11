using System;

namespace RobotsArena
{
    class Program
    {
        static void Main(string[] args)
        {
            // The BattleManager initializes The Arena by reading the input
            // from the file 'input.txt' located in the root directory
            var battleManager = new BattleManager();

            // The 'StartBattle' method loops through the robots and
            // engages each of them based on the movement instructions.
            // The output is displayed on the console.
            battleManager.StartBattle();

            Console.ReadKey();
        }
    }
}
