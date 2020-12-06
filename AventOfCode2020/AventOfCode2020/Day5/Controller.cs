using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Day5
{
    public static class Controller
    {

        public static List<BoardingPassSeat> GetallSeats()
        {
            var result = new List<BoardingPassSeat>();
            var input = ProcessInputDay5.GetInput();

            foreach(var line in input)
            {
                //Console.WriteLine(line);
                var seatLine = GetSeat(line);
                result.Add(seatLine);
                //Console.WriteLine($"Resultaat, Rij {seatLine.Row}, column {seatLine.Column} en stoelID {seatLine.SeatId}");
                //string resulaat = $"{seatLine.Row}|{seatLine.Column}|{seatLine.SeatId}";
                //Console.WriteLine(resulaat);
                
            }
            var maxId = FindMaxValue(result, x => x.SeatId);
           // Console.WriteLine($"MaxID = {maxId}");
            return result;
        }


        public static BoardingPassSeat GetSeat(string line)
        {
            var row = SeatLocator.GetRowNr(line);
            var column = SeatLocator.GetColumnNr(line);
            var seatId = SeatLocator.GetSeatId(row, column);
            var result = new BoardingPassSeat
            {
                Row = row,
                Column = column,
                SeatId = seatId
            };

            return result;
        }

        private static int FindMaxValue<T>(List<T> list, Converter<T, int> projection)
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            int maxValue = int.MinValue;
            foreach (T item in list)
            {
                int value = projection(item);
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }
            return maxValue;
        }

        public static char[,] GetPlaneMap()
        {
            var input = GetallSeats();

            var sizeX = 8;
            var sizeY = 127;
            var map = new char[sizeX, sizeY];
            foreach (var row in input)
            {
                map[row.Column, row.Row] = "X".ToCharArray()[0];
            }

           // WriteMap(map);
            
            return map;
        }

        public static void GetEmptySeat()
        {
            var sizeX = 7;
            var sizeY = 127;

            var map = new char[sizeX, sizeY];
            map = GetPlaneMap();
            var match = "X".ToCharArray()[0];
            var result = new List<BoardingPassSeat>();



            var i = 1;

        }

       

        private static void WriteMap(string[,] map)
        {
            var sizeX = 7;
            var sizeY = 127;

            for (int y = 0; y < sizeY; y++)
            {
                var message = string.Empty;
                for (int x = 0; x < sizeX; x++)
                {
                    message += map[x, y];
                }
                Console.WriteLine(message);

            }
        }

    }
}
