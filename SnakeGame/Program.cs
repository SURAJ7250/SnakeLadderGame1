using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.DieRoll();
            Console.WriteLine(game.DieRoll());
        }
    }
}
