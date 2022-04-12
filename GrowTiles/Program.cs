using System;

namespace GrowTiles
{
    class Program 
    {
        static void Main(string[] args) 
        {

            PlantGrid field = new PlantGrid(5,5);
            field.Grid[0,0] = new Flower(new Coord(0,0),0);
            field.DisplayGrid();

            while (true) {
                string input = Console.ReadLine();
                if (input == "exit" || input == "q") break;
                field.Update();
                field.DisplayGrid();
            }
        }
    }
}