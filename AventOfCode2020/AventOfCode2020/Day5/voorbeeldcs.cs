using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Day5
{
    public static  class voorbeeld
    {
        static List<int> seatIds = new List<int>();
        public static  void part1()
        {
            var lines = ProcessInputDay5.GetInput();

            int largestSeatId = 0;
            int row;
            int rowDivider;
            int columnDivider;
            int column;
            int seatId;

            foreach (string line in lines)
            {
                rowDivider = 64;
                columnDivider = 4;
                row = 0;
                column = 0;

                for (int i = 0; i <= 6; i++)
                {
                    if (line[i] == 'B')
                        row += rowDivider;

                    rowDivider /= 2;
                }

                for (int i = 7; i <= 9; i++)
                {
                    if (line[i] == 'R')
                        column += columnDivider;

                    columnDivider /= 2;
                }

                seatId = row * 8 + column;
                seatIds.Add(seatId);

                if (seatId > largestSeatId)
                {
                    largestSeatId = seatId;
                }
            }
            Console.WriteLine($"Part 1: {largestSeatId}");
            part2();
        }

        public static void part2()
        {
            int min = seatIds.Min(t => t);

            foreach (int x in seatIds.OrderBy(t => t))
            {
                if (x != min)
                {
                    Console.WriteLine($"Part 2: {min}");
                    break;
                }
                min++;
            }
        }

    }
}
