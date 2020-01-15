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

        }

    }
}
