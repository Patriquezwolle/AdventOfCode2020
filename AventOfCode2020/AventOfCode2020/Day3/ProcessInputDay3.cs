using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Day3
{
    public static class ProcessInputDay3
    {
        

        public static void GetMap()
        {
            var input = InputDay3.GetInputMap();

            var sizeX = 31;
            var sizeY = 323;
            var map = new char[sizeX, sizeY];
            var y = 0;
            
            foreach (var line in input)
            {
                var x = 0;
                foreach(char ch in line)
                {
                    map[x,y] = ch;
                    x++;
                }
                               
                y++;
            }

            WriteMap(map);


        }


        public static void WriteMap(char[,]map)
        {
            var sizeX = 31;
            var sizeY = 323;

            for (int y = 0; y < sizeY; y++)
            {
                var message = string.Empty;
                for (int x = 0; x < sizeX; x++)
                {
                    message += map[x,y];
                }
                Console.WriteLine(message);
            }
        }

    }
}
