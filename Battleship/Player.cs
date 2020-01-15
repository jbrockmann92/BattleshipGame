using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        //Member Variables (HAS A)
        string name;
        int score;
        Ship destroyer = new Ship("Destroyer", 2);
        Ship submarine = new Ship("Submarine", 3);
        Ship battleship = new Ship("Battleship", 4);
        Ship aircraftCarrier = new Ship("Aircraft Carrier", 5);


        //Constructor

        //Member Methods (CAN DO)

        public void Attack()
        {
            //CheckIfHit();
            //

        }

        public void CheckIfHit()
        {
            //Should be in Battle class?
            //Check if the location they hit 
            //if (battlefield.shotPlacement == 0
            //{
            //    Console.WriteLine("You missed!");
            //}
            //else if (battlefield.shotPlacement == 1)
            //{
            //    Console.WriteLine("You have hit!");
            //    Ship.health--;
            //}
        }

    }
}
