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
        int bombXAxis;
        int bombYAxis;
        Ship destroyer = new Ship("Destroyer", 2);
        Ship submarine = new Ship("Submarine", 3);
        Ship battleship = new Ship("Battleship", 4);
        Ship aircraftCarrier = new Ship("Aircraft Carrier", 5);
        List<Ship> ships = new List<Ship>();


        //Constructor

        //Member Methods (CAN DO)

        public void ShootBomb()
        {
            Console.WriteLine("Where would you like to shoot your bomb? Put the X-Axis first, then the Y-Axis");
            bombXAxis = int.Parse(Console.ReadLine());
            bombYAxis = int.Parse(Console.ReadLine());
        }

        public void CheckIfHit()
        {
            //Should be in Battle class?
            //Check if the location they hit 
            ShootBomb();
            if (bombYAxis == 0)
                //Probably won't work. This is calling the previous input, so will never be true. Need to have bombYAxis = whatever the axis is on the actual field
            {
                Console.WriteLine("You missed!");
            }
            //else if (battlefield.shotPlacement == 1)
            //{
            //    Console.WriteLine("You have hit!");
            //    Ship.health--;
            //}
        }

    }
}
