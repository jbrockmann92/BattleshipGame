using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        public string name;
        public int score;
        public int bombXAxis;
        public int bombYAxis;
        string verticalOrHorizontal;
        int verticalChoice;
        int horizontalChoice;
        public int[,] battlefield = new int[20, 20];
        Ship destroyer;
        Ship submarine;
        Ship battleship;
        Ship aircraftCarrier;
        List<Ship> ships = new List<Ship>() { new Ship("Destroyer", 2), new Ship("Submarine", 3), new Ship("Battleship", 4), new Ship("Aircraft Carrier", 5) };


        //Currently running verticalorhorizontal 4 times, then asking where they want it

        public void PlaceShips()
        {
            int counter = 0;
            while (counter < ships.Count)
            {
                foreach (Ship ship in ships)
                {
                    Console.WriteLine($"Would you like to place your {ship.name} vertically or horizontally?");
                    verticalOrHorizontal = Console.ReadLine().ToLower();

                    if (verticalOrHorizontal == "horizontal")
                    {
                        Console.WriteLine("Please enter the horizontal and vertical lines, 1-20, you'd like to place the ship at");
                        horizontalChoice = int.Parse(Console.ReadLine());
                        verticalChoice = int.Parse(Console.ReadLine());
                        battlefield[verticalChoice, horizontalChoice] = 1;
                        battlefield[verticalChoice, horizontalChoice - 1] = 1;
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
                    counter++;
                }
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
            this.battlefield = battlefield;
            if (battlefield[bombXAxis, bombYAxis] == 0)
            {
                Console.WriteLine("You missed!");
            }
            else if (battlefield[bombXAxis, bombYAxis] == 1)
            {
                Console.WriteLine("Hit!");
                score++;
                battlefield[bombXAxis, bombYAxis] = 0;
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
