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
        public int[,] battlefield = new int[20, 20];
        Ship destroyer = new Ship("Destroyer", 2);
        Ship submarine = new Ship("Submarine", 3);
        Ship battleship = new Ship("Battleship", 4);
        Ship aircraftCarrier = new Ship("Aircraft Carrier", 5);
        List<Ship> ships = new List<Ship>();


        //Constructor

        //Member Methods (CAN DO)

        public void VerticalOrHorizontal()
        {
            //WriteLine, then assign that value to either the x or y axis
            Console.WriteLine("Would you like to place your Destroyer vertically or horizontally?");
            verticalOrHorizontal = Console.ReadLine().ToLower();
        }

        public void PlaceShips()
        {
            VerticalOrHorizontal();

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

        public void ShootBomb()
        {
            Console.WriteLine("Where would you like to shoot your bomb? Put the X-Axis first, then the Y-Axis");
            bombXAxis = int.Parse(Console.ReadLine());
            bombYAxis = int.Parse(Console.ReadLine());
        }

        public void CheckIfHit(int[,] battlefield)
        {
            //this should work. Passing in whatever battlefield they're attacking, and it tests them
            this.battlefield = battlefield;
            //Should be in Battle class?
            //Check if the location they hit 
            if (battlefield[bombXAxis, bombYAxis] == 0)
            {
                Console.WriteLine("You missed!");
            }
            else if (battlefield[bombXAxis, bombYAxis] == 1)
            {
                Console.WriteLine("Hit!");
                score++;
            }
            Console.ReadLine();
        }
        public void PrintBattleField()
        {
            //place a series of numbers on the top and letters on the side, or just leave the user to enter [4, 2], etc.?
            int height = 20;
            int width = 20;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Console.Write(battlefield[x, y] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
