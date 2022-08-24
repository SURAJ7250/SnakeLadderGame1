using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Game
    {
        public int playerPosition = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int dieCount = random.Next(1, 7);
            return dieCount;
        }
    }
}