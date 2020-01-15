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
        public string name;
        public int score;
        public int bombXAxis;
        public int bombYAxis;
        string verticalOrHorizontal;
        int verticalChoice;
        int horizontalChoice;
        int[,] battlefield = new int[20, 20];
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

        public void VerticalOrHorizontal()
        {
            //WriteLine, then assign that value to either the x or y axis
            Console.WriteLine("Would you like to place your Destroyer vertically or horizontally?");
            verticalOrHorizontal = Console.ReadLine().ToLower();
        }

        public void PlaceShips()
        {
            //Ship.Length function here
            //VerticalOrHorizontal()???
            //playerOne.battleship, playerTwo.submarine or something
            VerticalOrHorizontal();
            //Not exactly sure how to place the ships the right way
            if (verticalOrHorizontal == "horizontal")
            {
                Console.WriteLine("Please enter the horizontal and vertical lines, 1-20, you'd like to place the ship at");
                horizontalChoice = int.Parse(Console.ReadLine());
                verticalChoice = int.Parse(Console.ReadLine());
                battlefield[verticalChoice, horizontalChoice] = 1;
                battlefield[verticalChoice, horizontalChoice - 1] = 1;

                //Need to find how to put the length vertically or horizontally along the axis
            }
            else if (verticalOrHorizontal == "vertical")
            {
                Console.WriteLine("Please enter the horizontal and vertical lines, 1-20, you'd like to place the ship at");
                horizontalChoice = int.Parse(Console.ReadLine());
                verticalChoice = int.Parse(Console.ReadLine());
                battlefield[verticalChoice, horizontalChoice] = 1;
                battlefield[verticalChoice - 1, horizontalChoice] = 1;
                //Probably need a loop for the ship.Length to iterate and add to a variable or something. Doesn't work very well right now
            }
        }

    }
}
