using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Day3
{
    public static class Navigator
    {

        public static void Navigate3to1()
        {
            var trees = new List<string>();
            var map = ProcessInputDay3.GetMapFull();
            int verticalStep = 1;
            int horizontalStep = 3;
            int sizeY = 323;
            trees = Navigate(map, horizontalStep, verticalStep, sizeY);
            var nrofTrees = trees.Count;
            Console.WriteLine($" Aantal bomen: {nrofTrees} ");
            //145
        }

        public static void NavigateRoutes()
        {
            int sizeY = 323;
            var map = ProcessInputDay3.GetMapFull();
            var treesR1 = new List<string>();
            var treesR2 = new List<string>();
            var treesR3 = new List<string>();
            var treesR4 = new List<string>();
            var treesR5 = new List<string>();
            treesR1 = Navigate(map, 1, 1, sizeY);
            treesR2 = Navigate(map, 3, 1, sizeY);
            treesR3 = Navigate(map, 5, 1, sizeY);
            treesR4 = Navigate(map, 7, 1, sizeY);
            treesR5 = Navigate(map, 1, 2, sizeY);

            uint nrTrees1 = (uint)treesR1.Count;
            uint nrTrees2 = (uint)treesR2.Count;
            uint nrTrees3 = (uint)treesR3.Count;
            uint nrTrees4 = (uint)treesR4.Count;
            uint nrTrees5 = (uint)treesR5.Count;
            uint total = nrTrees1 * nrTrees2 * nrTrees3 * nrTrees4 * nrTrees5;
            Console.WriteLine($"Aantal bomen1 {nrTrees1} \n Aantal bomen2 {nrTrees2} \n Aantal bomen3 {nrTrees3} \n Aantal bomen4 {nrTrees4} \n Aantal bomen5 {nrTrees5}");
            Console.WriteLine($"Totaal aantal bomen is: {total}");
            
            //uint y = 3424528800;
        }


        public static List<string> Navigate(char[,] map, int horizontalStep, int verticalStep, int sizeY)
        {
            var result = new List<string>();
            var tree = "#".ToCharArray()[0];
            int x = 0;
            int y = 0;
            for (int i = 0; i < sizeY; i++)
            {
                char point = map[x, y];
                if (point == tree)
                {
                    result.Add($"One tree found at {x}, {y}");
                }
                if (verticalStep == 2)
                {
                    i++;
                }
                x = x + horizontalStep;
                y = y + verticalStep;
            }
            return result;
        }




    }
}
