using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Battle battle = new Battle();
            battle.PrintBattleField();
            battle.VerticalOrHorizontal();
            battle.PlaceShips();
            battle.PrintBattleField();
            battle.CheckIfHit();
        }
    }
}
