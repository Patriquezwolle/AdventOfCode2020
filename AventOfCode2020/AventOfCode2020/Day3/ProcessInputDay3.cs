using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Day3
{
    public static class ProcessInputDay3
    {
        

        public static void GetMapOnce()
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

        public static char[,] GetMapFull()
        {
            var input = InputDay3.GetInputMap();
            var sizeBlock = 31;
            var sizeX = 3100;
            var sizeY = 324;

            var map = new char[sizeX, sizeY];
            int i = 0;
            while (i < 100)
            {
                var offset = i * sizeBlock;
                map = Repeater(map, offset, sizeBlock, input);
                i++;
            }
            //WriteMap(map);
            return map;
        }

        public static char[,] GetMapFullExample()
        {
            var input = InputDay3.GetInputMap();
            var sizeBlock = 66;
            var sizeX = 132;
            var sizeY = 11;

            var map = new char[sizeX, sizeY];
            int i = 0;
            while (i < 2)
            {
                var offset = i * sizeBlock;
                map = Repeater(map, offset, sizeBlock, input);
                i++;
            }
            //WriteMap(map);
            return map;
        }


        private static char[,] Repeater(char[,]map, int offset, int sizeBlock, List<string> input)
        {
            int y = 0;
            foreach (var line in input)
            {
                var x = 0 + offset;
                foreach (char ch in line)
                {
                    map[x, y] = ch;
                    x++;
                }
                y++;
            }
            return map;
        }


        public static void WriteMap(char[,]map)
        {
            var sizeX = 992;
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
