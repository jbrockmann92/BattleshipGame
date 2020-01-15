using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Battle
    {
        //Instantiate 2 players here.
        //Probably place CheckIfHit() here too
        //Clear the console after each turn
        //Battle should have turns, not Player
        //Write 2D array here as well. Just a variable?


        int turn;
        //Set each value in battlefield to '.' at the moment
        string[,] battlefield = new string[20, 20];


        public void PlaceShips()
        {
            Console.WriteLine(battlefield);
            Console.ReadLine();
        }

        public void CheckIfHit()
        {

        }

    }
}
